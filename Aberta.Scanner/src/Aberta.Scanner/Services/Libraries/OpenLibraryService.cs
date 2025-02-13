using Aberta.Scanner.Contracts.Services.Libraries;
using Aberta.Scanner.Models;
using Newtonsoft.Json;
using Serilog;

namespace Aberta.Scanner.Services.Libraries;

public class OpenLibraryService(IConfiguration config) : IOpenLibraryService
{
    public async Task<Book> GetBook(string isbn)
    {
        var book = new Book()
        {
            Title = "",
            Author = "",
            Price = 0,
            Stock = 0,
            IsActive = false,
        };

        try
        {
            Log.Information($"[{isbn}] Retrieving book from OpenLibrary...");

            isbn = Utils.CleanIsbn(isbn);


            var client = new HttpClient();
            client.BaseAddress = new Uri($"{config.GetValue<string>("AbertaApi:BaseUrl")}ol");

            var request = await client.GetAsync($"?isbn={isbn}");

            if (request.IsSuccessStatusCode)
            {
                var bookJson = await request.Content.ReadAsStringAsync();
                var bookWrap = JsonConvert.DeserializeObject<ResultWrapper<Book>>(bookJson);
                book = bookWrap.Data;
            }
            else
            {
                Log.Information($"[{isbn}] Could not retrieve book. {request.StatusCode}");
            }

            return book;
        }
        catch (Exception e)
        {
            Log.Error(e, ".NET error");
            return book;
        }
    }
}