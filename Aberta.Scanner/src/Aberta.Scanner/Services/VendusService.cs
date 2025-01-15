using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using AbertaScanner.Contracts.Services;
using AbertaScanner.Models;
using Newtonsoft.Json;
using Serilog;

namespace AbertaScanner.Services;

public class VendusService : IVendusService
{
    private readonly IConfiguration _config;

    public VendusService(IConfiguration config)
    {
        _config = config;
    }

    public async Task<ResultWrapper<Book>> GetBook(string isbn) 
    {
        ResultWrapper<Book> book = new ResultWrapper<Book>();

        try
        {
            Log.Information($"[{isbn}] Retrieving book from OpenLibrary...");
            isbn = Utils.CleanIsbn(isbn);

            // get book in json format by isbn 
            HttpResponseMessage request = await Utils.GetAsync($"{_config.GetValue<string>("AbertaApi:BaseUrl")}vendus?isbn={isbn}");

            if (request.IsSuccessStatusCode)
            {
                string response = request.Content.ReadAsStringAsync().Result;
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
        ResultWrapper<List<Book>> book = new ResultWrapper<List<Book>>();
        
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{_config.GetValue<string>("AbertaApi:BaseUrl")}vendus/batch");
            client.DefaultRequestHeaders.Add("X-API-KEY", _config.GetValue<string>("AbertaApi:ApiKey"));
            
            HttpResponseMessage request = await client.GetAsync($"?numberOfResults={bookCount}&page={page}");

            if (request.IsSuccessStatusCode)
            {
                string response = request.Content.ReadAsStringAsync().Result;
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
            client.BaseAddress = new Uri(_config.GetValue<string>("AbertaApi:BaseUrl"));
            client.DefaultRequestHeaders.Add("X-API-KEY", _config.GetValue<string>("AbertaApi:ApiKey"));
                        
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