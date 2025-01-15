using AbertaApi;
using AbertaApi.Contracts.Services;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;
using Newtonsoft.Json;
using Serilog;

namespace AbertaScanner.Services;

public class VendusService(IConfiguration config) : IVendusService
{
    private readonly IConfiguration _config = config;

    public async Task<ResultWrapper<Book>> GetBook(string isbn) 
    {
        ResultWrapper<Book> result = new ResultWrapper<Book>();

        // request data from vendus
        HttpClient client = new HttpClient();

        string? apiKey = _config.GetValue<string>("VendusApi");

        HttpResponseMessage response = await client.GetAsync(
            $"https://www.vendus.pt/ws/v1.1/products/?api_key={apiKey}&category_id=67682863&reference={isbn}"
        );

        if (response.IsSuccessStatusCode)
        {
            try
            {
                List<Product?>? products =
                    JsonConvert.DeserializeObject<List<Product?>>(response.Content.ReadAsStringAsync().Result);

                if (products != null && products.Count > 0)
                {
                    result.Data = Book.ProductToBook(products[0]);
                    result.IsSuccessful = true;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return result;
            }
        }

        return result;
    }

    public async Task<ResultWrapper<List<Book>>> GetBatchOfBookStock(int bookCount, int page)
    {
        ResultWrapper<List<Book>> result = new ResultWrapper<List<Book>>();

        HttpClient client = new HttpClient();
        List<Book> books = [];

        string? apiKey = _config.GetValue<string>("VendusApi");

        HttpResponseMessage response = await client.GetAsync(
            $"https://www.vendus.pt/ws/v1.1/products/?api_key={apiKey}&category_id=67682863&per_page={bookCount}&page={page}"
        );

        if (response.IsSuccessStatusCode)
        {
            try
            {
                List<Product>? products = JsonConvert.DeserializeObject<List<Product>>(
                    response.Content.ReadAsStringAsync().Result
                );

                if (products != null && products.Count > 0)
                {
                    foreach (Product product in products)
                    {
                        product.Reference = Utils.CleanIsbn(product.Reference);
                        Book newBook = Book.ProductToBook(product);
                        books.Add(newBook);
                        
                    }

                    result.Data = books;
                    result.IsSuccessful = true;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }

        return result;
    }
}