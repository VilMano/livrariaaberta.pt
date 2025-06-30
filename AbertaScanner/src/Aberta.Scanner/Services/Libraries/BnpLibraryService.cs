using Aberta.Scanner.Contracts.Services.Libraries;
using Aberta.Scanner.Models;
using Newtonsoft.Json;
using Serilog;

namespace Aberta.Scanner.Services.Libraries;

public class BnpLibraryService(IConfiguration config) : IBnpLibraryService
{
    public async Task<Book> GetBook(string isbn)
    {
        Book book = new Book()
        {
            Title = "",
            Author = "",
            Price = 0,
            Stock = 0,
            IsActive = false
        };
        try
        {
            Log.Information($"[{isbn}] Retrieving book from OpenLibrary...");
            isbn = Utils.CleanIsbn(isbn);

            var client = new HttpClient();
            client.BaseAddress = new Uri($"{config.GetValue<string>("AbertaApi:BaseUrl")}bnp");

            var request = await client.GetAsync($"?isbn={isbn}");

            if (request.IsSuccessStatusCode)
            {
                var response = request.Content.ReadAsStringAsync().Result;
                var bookWrap = JsonConvert.DeserializeObject<ResultWrapper<Book>>(response);
                book = bookWrap.Data;
                
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