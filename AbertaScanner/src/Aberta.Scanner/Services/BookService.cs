using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Aberta.Scanner.Contracts.Services;
using Aberta.Scanner.Contracts.Services.Libraries;
using Aberta.Scanner.Models;
using Newtonsoft.Json;
using Serilog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Aberta.Scanner.Services;

public class BookService(
    IOpenLibraryService openLibService,
    IBnpLibraryService bnpLibService,
    IVendusService vendusService,
    IConfiguration config,
    ILogger<BookService> logger)
    : IBookService
{
    public async Task VendusProcessing()
    {
        const int batchCount = 25;
        var page = 1;

        var stockBooks = new ResultWrapper<List<Book>>();
        var stop = false;

        do
        {
            try
            {
                logger.LogInformation($"Getting batch of books from Vendus... {batchCount}:{page}");
                stockBooks = await vendusService.GetBatchOfBookStock(batchCount, page);

                if (stockBooks.Data is { Count: > 0 })
                {
                    logger.LogInformation("Vendus returned data successfully.");
                    
                    // insert books in the database
                    foreach (var book in stockBooks.Data)
                    {
                        logger.LogInformation($"Getting book {book.Isbn}");
                        var existingBook = await GetBookFromAbertaAPI(book.Isbn);
                        if (existingBook is { Data: not null })
                        {
                            logger.LogInformation($"Book found, updating...");
                            
                            existingBook.Data.Stock = book.Stock;
                            existingBook.Data.Price = book.Price;

                            await UpdateBook(existingBook.Data);
                        }
                        else
                        {
                            logger.LogInformation($"Book NOT found, creating...");
                            
                            book.IsActive = false;
                            await CreateBook(book);
                        }
                    }
                }
                else
                {
                    logger.LogInformation($"No data was retrieved.");
                    stop = true;
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.Message, e);
            }

            page++;
        } while (!stop);
        
        logger.LogInformation("Finished getting batch of books from Vendus.");
    }

    public async Task UpdateWithLibraries()
    {
        var books = new List<Book>();

        try
        {
            var activeBooks = await GetBooksFromAbertaAPI(20000, 1, true);
            var inactiveBooks = await GetBooksFromAbertaAPI(20000, 1, false);

            if (activeBooks is { Data: not null })
            {
                books.AddRange(activeBooks.Data.results);
            }
            
            if (inactiveBooks is { Data: not null })
            {
                books.AddRange(inactiveBooks.Data.results);
            }

            foreach (var book in books)
            {
                var bnpBook = await bnpLibService.GetBook(book.Isbn);
                var olBook = await openLibService.GetBook(book.Isbn);

                var fullBook = Utils.JoinObjects<Book>(bnpBook, olBook);

                if (book.Language == null || string.IsNullOrEmpty(book.Language))
                    book.Language = fullBook.Language ?? "";

                if (book.ReleaseDate == null || string.IsNullOrEmpty(book.ReleaseDate))
                    if (fullBook.ReleaseDate != null || !string.IsNullOrEmpty(fullBook.ReleaseDate))
                        book.ReleaseDate = Utils.CaptureYearInDate(fullBook.ReleaseDate);

                await UpdateBook(book);
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
        }
    }

    private async Task<ResultWrapper<BookResults>> GetBooksFromAbertaAPI(int batchCount, int page, bool active)
    {
        var books = new ResultWrapper<BookResults>();

        var client = new HttpClient();
        var activeState = active ? "active" : "inactive";
        client.BaseAddress = new Uri(config.GetValue<string>("AbertaApi:BaseUrl") + $"all/{activeState}");
        client.DefaultRequestHeaders.Add("X-API-KEY", config.GetValue<string>("AbertaApi:ApiKey"));

        var search = new Search()
        {
            Page = page,
            NumberOfResults = batchCount,
            SortBy = "alpha",
            SortOrder = "asc",
            SearchTerm = ""
        };

        var fetchedBookRequest =
            await client.PostAsJsonAsync("", search);

        if (fetchedBookRequest.IsSuccessStatusCode)
        {
            var result = await fetchedBookRequest.Content.ReadAsStringAsync();
            books = JsonConvert.DeserializeObject<ResultWrapper<BookResults>>(result);
            books.IsSuccessful = true;
        }
        else
        {
            books.IsSuccessful = false;
        }

        return books;
    }

    private async Task<ResultWrapper<Book>> GetBookFromAbertaAPI(string isbn)
    {
        var book = new ResultWrapper<Book>();

        var client = new HttpClient();
        client.BaseAddress = new Uri(config.GetValue<string>("AbertaApi:BaseUrl"));
        client.DefaultRequestHeaders.Add("X-API-KEY", config.GetValue<string>("AbertaApi:ApiKey"));

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        var attributes = $"?isbn={isbn}";
        var fetchedBookRequest =
            await client.GetAsync("single" + attributes);

        if (fetchedBookRequest.IsSuccessStatusCode)
        {
            var result = await fetchedBookRequest.Content.ReadAsStringAsync();
            book = JsonConvert.DeserializeObject<ResultWrapper<Book>>(result);
            book.IsSuccessful = true;
        }
        else
        {
            book.IsSuccessful = false;
        }

        return book;
    }

    private async Task CreateBook(Book book)
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri(config.GetValue<string>("AbertaApi:BaseUrl"));
        client.DefaultRequestHeaders.Add("X-API-KEY", config.GetValue<string>("AbertaApi:ApiKey"));

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        JsonSerializerOptions options = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true
        };

        var res = await client.PostAsJsonAsync("create", book, options);
    }

    private async Task UpdateBook(Book book)
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri(config.GetValue<string>("AbertaApi:BaseUrl"));
        client.DefaultRequestHeaders.Add("X-API-KEY", config.GetValue<string>("AbertaApi:ApiKey"));

        JsonSerializerOptions options = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true
        };

        var res = await client.PostAsJsonAsync("update", book, options);
    }
}