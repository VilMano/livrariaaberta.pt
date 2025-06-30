using System.Net.Http.Headers;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;
using Newtonsoft.Json;
using Serilog;

namespace Aberta.API.Services;

public class OpenLibraryService(IConfiguration config, ILogger<OpenLibraryService> logger) : IOpenLibraryService
{
    public async Task<ResultWrapper<Book>> GetBook(string isbn)
    {
        logger.LogInformation("Getting book from Open Library...");
        var books = new ResultWrapper<Book>();

        try
        {
            isbn = Utils.Utils.CleanIsbn(isbn);

            var client = new HttpClient();
            client.BaseAddress = new Uri($"{config.GetValue<string>("OpenLibrary:BaseUrl")}isbn/{isbn}.json");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
            var request = await client.GetAsync("");

            if (!request.IsSuccessStatusCode) return books;
            
            var bookJson = request.Content.ReadAsStringAsync().Result;
            books.Data = await OpenLibraryJsonToBook(bookJson);
            books.IsSuccessful = true;

            return books;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
        }
        
        return books;
    }

    private async Task<string> GetLanguage(string language)
    {
        try
        {
            // make sure language doesn't have unecessary whitespace
            language = language.Trim();
            
            var client = new HttpClient();
            client.BaseAddress = new Uri($"{config.GetValue<string>("OpenLibrary:BaseUrl")+language}.json");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
            
            var request = await client.GetAsync("");

            var languageString = await request.Content.ReadAsStringAsync();
            return request.IsSuccessStatusCode ? languageString : "";
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            return "";
        }
    }

    private async Task<Book> OpenLibraryJsonToBook(string json)
    {
        Book openLibraryBook = new()
        {
            Title = null,
            Stock = 0,
            Price = 0,
            IsActive = false
        };

        try
        {
            if (!json.Contains("\"error\": \"notfound\""))
            {
                var book = JsonConvert.DeserializeObject<OlObject>(json);

                if (book.PublishDate != null)
                    openLibraryBook.ReleaseDate = book.PublishDate;

                if (book.Languages != null)
                {
                    var result = await GetLanguage(book.Languages[0].Key!);
                    dynamic jsonData = JsonConvert.DeserializeObject(result) ?? "";

                    string languageTranslated = jsonData["name_translated"]["pt"][0] ?? "";
                    openLibraryBook.Language = languageTranslated;
                }
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
        }

        return openLibraryBook;
    }
}