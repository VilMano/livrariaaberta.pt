using AbertaScanner.Contracts.Services.Libraries;
using AbertaScanner.Models;
using Newtonsoft.Json;
using Serilog;

namespace AbertaScanner.Services.Libraries;

public class BnpLibraryService : IBnpLibraryService
{
    private readonly IConfiguration _configuration;

    public BnpLibraryService(IConfiguration config)
    {
        _configuration = config;
    }
    
    public async Task<Book> GetBook(string isbn)
    {
        Book book = new Book();
        try
        {
            Log.Information($"[{isbn}] Retrieving book from OpenLibrary...");
            isbn = Utils.CleanIsbn(isbn);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{_configuration.GetValue<string>("AbertaApi:BaseUrl")}bnp");

            HttpResponseMessage request = await HttpRequests.GetAsync(client, $"?isbn={isbn}");

            if (request.IsSuccessStatusCode)
            {
                string response = request.Content.ReadAsStringAsync().Result;
                book = JsonConvert.DeserializeObject<Book>(response);
                
                return book;
            }
            else
            {
                Log.Information($"[{isbn}] Could not retrieve book. {request.StatusCode}");
                return null;
            }
        }
        catch (Exception e)
        {
            Log.Error(e, ".NET error");
            return null;
        }
    }
}