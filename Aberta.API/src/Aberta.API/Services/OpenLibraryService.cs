using System.Net.Http.Headers;
using AbertaApi;
using AbertaApi.Contracts.Services;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;
using Newtonsoft.Json;
using Serilog;

namespace AbertaScanner.Services;

public class OpenLibraryService(IConfiguration config) : IOpenLibraryService
{
    private readonly IConfiguration _config = config;

    public async Task<ResultWrapper<Book>> GetBook(string isbn)
    {
        ResultWrapper<Book> books = new ResultWrapper<Book>();

        try
        {
            isbn = Utils.CleanIsbn(isbn);

            var client = new HttpClient();
            client.BaseAddress = new Uri($"{_config.GetValue<string>("OpenLibrary:BaseUrl")}isbn/{isbn}.json");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
            HttpResponseMessage request = await Utils.GetAsync(client, "");

            if (request.IsSuccessStatusCode)
            {
                string bookJson = request.Content.ReadAsStringAsync().Result;
                books.Data = await OpenLibraryJsonToBook(bookJson);
                books.IsSuccessful = true;

                return books;
            }
            else
            {
                return books;
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
        }
        
        return books;
    }

    private async Task<string> GetAuthor(string author)
    {
        try
        {
            // make sure isbn doesn't have unecessary whitespace
            author = author.Trim();

            var client = new HttpClient();
            client.BaseAddress = new Uri($"{_config.GetValue<string>("OpenLibrary:BaseUrl") + author}.json");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
            HttpResponseMessage request = await Utils.GetAsync(client, "");

            if (request.IsSuccessStatusCode)
            {
                return request.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return "";
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            return "";
        }
    }

    private async Task<string> GetLanguage(string language)
    {
        try
        {
            // make sure language doesn't have unecessary whitespace
            language = language.Trim();


            var client = new HttpClient();
            client.BaseAddress = new Uri($"{_config.GetValue<string>("OpenLibrary:BaseUrl")+language}.json");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
            
            HttpResponseMessage request = await Utils.GetAsync(client,"");

            if (request.IsSuccessStatusCode)
            {
                return request.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return "";
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            return "";
        }
    }

    private async Task<Book> OpenLibraryJsonToBook(string json)
    {
        Book openLibraryBook = new();

        try
        {
            if (!json.Contains("\"error\": \"notfound\""))
            {
                OlObject? book = JsonConvert.DeserializeObject<OlObject>(json);

                if(book.Isbn10 is { Length: >0 })
                    openLibraryBook.Isbn = book.Isbn10[0];

                if (book.Title != null)
                    openLibraryBook.Title = book.Title;

                if (book.Authors != null)
                {
                    string result = await GetAuthor(book.Authors[0].Key);
                    dynamic fetchedAuthor = JsonConvert.DeserializeObject(result);

                    openLibraryBook.Author = fetchedAuthor["name"];
                }

                if (book.PublishDate != null)
                    openLibraryBook.ReleaseDate = book.PublishDate;

                if (book.Publishers != null)
                {
                    int i = 0;
                    int pubCount = book.Publishers.Length;
                    foreach (string publisher in book.Publishers)
                    {
                        if(pubCount -1 > i)
                            openLibraryBook.Publisher += publisher + ", ";
                        
                        i++;
                    }
                }

                if (book.Languages != null)
                {
                    string result = await GetLanguage(book.Languages[0].Key);
                    dynamic jsonData = JsonConvert.DeserializeObject(result);

                    string languageTranslated = jsonData["name_translated"]["pt"][0];
                    openLibraryBook.Language = languageTranslated;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException);
        }

        return openLibraryBook;
    }
}