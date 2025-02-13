using AbertaApi.Contracts.Services;
using AbertaApi.Models;
using Newtonsoft.Json;
using Serilog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Aberta.API.Services;

public class VendusService(IConfiguration config, ILogger<VendusService> logger) : IVendusService
{
    public async Task<ResultWrapper<Book>> GetBook(string isbn) 
    {
        logger.LogInformation("Getting product from Vendus...");
        var result = new ResultWrapper<Book>();

        // request data from vendus
        var client = new HttpClient();
        var apiKey = config.GetValue<string>("VendusApi");

        var response = await client.GetAsync(
            $"https://www.vendus.pt/ws/v1.1/products/?api_key={apiKey}&category_id=67682863&reference={isbn}"
        );

        if (!response.IsSuccessStatusCode)
        {
            logger.LogInformation("The Vendus API returned an error.");
            return result;
        }
        
        try
        {
            var res = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product?>>(res);

            if (products is { Count: > 0 })
            {
                result.Data = Book.ProductToBook(products.First()!);

                if (result.Data != null)
                {
                    result.Data.Publisher = await GetPublisherFromProduct(products.First()!);
                }
                    
                result.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            return result;
        }

        return result;
    }

    public async Task<ResultWrapper<List<Book>>> GetBatchOfBookStock(int bookCount, int page)
    {
        logger.LogInformation("Getting batch of books stock at Vendus...");
        var result = new ResultWrapper<List<Book>>();

        var client = new HttpClient();
        List<Book> books = [];

        var apiKey = config.GetValue<string>("VendusApi");

        var response = await client.GetAsync(
            $"https://www.vendus.pt/ws/v1.1/products/?api_key={apiKey}&category_id=67682863&per_page={bookCount}&page={page}"
        );

        if (!response.IsSuccessStatusCode)
        {
            logger.LogInformation("The Vendus API returned an error.");
            return result;
        }
        
        try
        {
            var products = JsonConvert.DeserializeObject<List<Product>>(
                response.Content.ReadAsStringAsync().Result
            );

            if (products is { Count: > 0 })
            {
                foreach (var product in products)
                {
                    product.Reference = Utils.Utils.CleanIsbn(product.Reference);
                    var newBook = Book.ProductToBook(product);
                    newBook.Publisher = await GetPublisherFromProduct(products[0]);
                        
                    books.Add(newBook);
                        
                }

                result.Data = books;
                result.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
        }

        return result;
    }

    private async Task<string> GetPublisherFromProduct(Product product)
    {
        var clientBrand = new HttpClient();

        var apiKey = config.GetValue<string>("VendusApi");
        var responseBrand = await clientBrand.GetAsync(
            $"https://www.vendus.pt/ws/v1.1/products/brands/{product.Brand}?api_key={apiKey}"
        );

        var response = await responseBrand.Content.ReadAsStringAsync();
        var publisher =
            JsonConvert.DeserializeObject<Publisher>(response);

        if (!responseBrand.IsSuccessStatusCode || publisher == null)
        {
            logger.LogInformation("No brand found in Vendus API.");
            return "";
        }
        return publisher.Title ?? "";
    }
}