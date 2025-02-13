using System.Net.Http.Headers;
using Aberta.Scanner.Models;
using Aberta.Scanner.Contracts.Services;
using Newtonsoft.Json;
using Serilog;

namespace Aberta.Scanner.Services;

public class VendusService(IConfiguration config) : IVendusService
{
    public async Task<ResultWrapper<Book>> GetBook(string isbn) 
    {
        var book = new ResultWrapper<Book>();

        try
        {
            Log.Information($"[{isbn}] Retrieving book from OpenLibrary...");
            isbn = Utils.CleanIsbn(isbn);

            var client = new HttpClient();
            client.BaseAddress = new Uri($"{config.GetValue<string>("AbertaApi:BaseUrl")}vendus?isbn={isbn}");
            client.DefaultRequestHeaders.Add("X-API-KEY", config.GetValue<string>("AbertaApi:ApiKey"));
            
            // get book in json format by isbn 
            var request = await client.GetAsync("");

            if (request.IsSuccessStatusCode)
            {
                var response = request.Content.ReadAsStringAsync().Result;
                book.Data = JsonConvert.DeserializeObject<Book>(response);
            }
        }
        catch (Exception e)
        {
            Log.Error(e, ".NET error");
            return null;
        }

        return book;
    }

    public async Task<ResultWrapper<List<Book>>> GetBatchOfBookStock(int bookCount, int page)
    {
        var book = new ResultWrapper<List<Book>>();
        
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{config.GetValue<string>("AbertaApi:BaseUrl")}vendus/batch");
            client.DefaultRequestHeaders.Add("X-API-KEY", config.GetValue<string>("AbertaApi:ApiKey"));
            
            HttpResponseMessage request = await client.GetAsync($"?numberOfResults={bookCount}&page={page}");

            if (request.IsSuccessStatusCode)
            {
                var response = await request.Content.ReadAsStringAsync();
                book = JsonConvert.DeserializeObject<ResultWrapper<List<Book>>>(response);
            }
        }
        catch (Exception e)
        {
            Log.Error(e, ".NET error");
            return null;
        }

        return book;
    }
    
    public async Task<ResultWrapper<Book>> CreateBook(Book book)
    {
        ResultWrapper<Book> bookResult = new ResultWrapper<Book>();
        
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(config.GetValue<string>("AbertaApi:BaseUrl"));
            client.DefaultRequestHeaders.Add("X-API-KEY", config.GetValue<string>("AbertaApi:ApiKey"));
                        
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage res = await client.PostAsJsonAsync("update", book);

            if (res.IsSuccessStatusCode)
            {
                bookResult.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            Log.Error(e, ".NET error");
            bookResult.Errors.Add(e.Message);
        }

        return bookResult;
    }
}