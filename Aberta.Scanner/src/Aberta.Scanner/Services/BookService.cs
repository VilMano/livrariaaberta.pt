using System.Net.Http.Headers;
using AbertaScanner.Contracts.Services;
using AbertaScanner.Contracts.Services.Libraries;
using AbertaScanner.Models;
using Newtonsoft.Json;
using Serilog;

namespace AbertaScanner.Services;

public class BookService : IBookService
{
    private readonly IOpenLibraryService _olService;
    private readonly IBnpLibraryService _bnpService;

    private readonly IVendusService _vendusService;
    private readonly IConfiguration _config;

    public BookService(
        IOpenLibraryService openLibService,
        IBnpLibraryService bnpLibService,
        IVendusService vendusService,
        IConfiguration config
    )
    {
        _olService = openLibService;
        _bnpService = bnpLibService;
        _vendusService = vendusService;
        _config = config;
    }

    public async Task VendusProcessing()
    {
        int batchCount = 25;
        int page = 1;
        int resultCount = 0;

        do
        {
            ResultWrapper<List<Book>> stockBooks = await _vendusService.GetBatchOfBookStock(batchCount, page);

            if (stockBooks.Data is { Count: > 0 })
            {
                resultCount = stockBooks.Data.Count;
                // insert books in the database
                foreach (Book book in stockBooks.Data)
                {
                    ResultWrapper<Book> existingBook = await GetBookFromAbertaAPI(book.Isbn);
                    if (existingBook is { Data: not null })
                    {
                        existingBook.Data.Stock = book.Stock;
                        existingBook.Data.Price = book.Price;

                        await _vendusService.CreateBook(existingBook.Data);
                    }
                    else
                    {
                        await _vendusService.CreateBook(book);
                    }
                }
            }
            else
            {
                resultCount = 0;
            }

            page++;
        } while (resultCount == batchCount);
    }

    public async Task UpdateWithLibraries()
    {
        ResultWrapper<BookDTO> bookJSON = new ResultWrapper<BookDTO>();

        int batchCount = 25;
        int page = 1;

        try
        {
            do
            {
                bookJSON = await GetBooksFromAbertaAPI(batchCount, page);

                foreach (var book in bookJSON.Data.results)
                {
                    Book bnpBook = await _bnpService.GetBook(book.Isbn);
                    Book olBook = await _olService.GetBook(book.Isbn);

                    Book fullBook = Utils.JoinObjects<Book>(bnpBook, olBook);

                    if (book.Author == null || string.IsNullOrEmpty(book.Author))
                        book.Author = fullBook.Author ?? "";

                    if (book.Publisher == null || string.IsNullOrEmpty(book.Publisher))
                        book.Publisher = fullBook.Publisher ?? "";

                    if (book.Language == null || string.IsNullOrEmpty(book.Language))
                        book.Language = fullBook.Language ?? "";

                    if (book.ReleaseDate == null || string.IsNullOrEmpty(book.ReleaseDate))
                        if (fullBook.ReleaseDate != null || !string.IsNullOrEmpty(fullBook.ReleaseDate))
                            book.ReleaseDate = Utils.CaptureYearInDate(fullBook.ReleaseDate);

                    await CreateBook(book);
                }

                page++;
            } while (bookJSON.Data.results.Count == batchCount);
        }
        catch (Exception e)
        {
            Log.Error(e, e.Message);
            throw;
        }
    }

    public async Task<ResultWrapper<BookDTO>> GetBooksFromAbertaAPI(int batchCount, int page)
    {
        ResultWrapper<BookDTO> books = new ResultWrapper<BookDTO>();

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_config.GetValue<string>("AbertaApi:BaseUrl") + "all");
        client.DefaultRequestHeaders.Add("X-API-KEY", _config.GetValue<string>("AbertaApi:ApiKey"));

        Search search = new Search()
        {
            Page = page,
            NumberOfResults = batchCount,
            SortBy = "alpha",
            SortOrder = "asc",
            SearchTerm = ""
        };

        var fetchedBookRequest =
            await client.PostAsJsonAsync("all", search);

        if (fetchedBookRequest.IsSuccessStatusCode)
        {
            string result = fetchedBookRequest.Content.ReadAsStringAsync().Result;
            books = JsonConvert.DeserializeObject<ResultWrapper<BookDTO>>(result);
            books.IsSuccessful = true;
        }
        else
        {
            books.IsSuccessful = false;
        }

        return books;
    }

    public async Task<ResultWrapper<Book>> GetBookFromAbertaAPI(string isbn)
    {
        ResultWrapper<Book> book = new ResultWrapper<Book>();

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_config.GetValue<string>("AbertaApi:BaseUrl"));
        client.DefaultRequestHeaders.Add("X-API-KEY", _config.GetValue<string>("AbertaApi:ApiKey"));

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        string attributes = $"?isbn={isbn}";
        var fetchedBookRequest =
            await client.GetAsync("single" + attributes);

        if (fetchedBookRequest.IsSuccessStatusCode)
        {
            string result = fetchedBookRequest.Content.ReadAsStringAsync().Result;
            book = JsonConvert.DeserializeObject<ResultWrapper<Book>>(result);
            book.IsSuccessful = true;
        }
        else
        {
            book.IsSuccessful = false;
        }

        return book;
    }

    public async Task CreateBook(Book book)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_config.GetValue<string>("AbertaApi:BaseUrl"));
        client.DefaultRequestHeaders.Add("X-API-KEY", _config.GetValue<string>("AbertaApi:ApiKey"));

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        var res = await client.PostAsJsonAsync("update", book);
    }
}