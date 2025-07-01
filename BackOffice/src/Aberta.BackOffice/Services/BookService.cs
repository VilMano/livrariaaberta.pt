using AbertaApi.Models;
using AbertaBackOffice.Models;
using Newtonsoft.Json;

namespace AbertaBackOffice.Services;

public class BookService(IConfiguration configuration, Requests requests)
{
    public async Task<ResultWrapper<Book>> GetBook(string isbn)
    {
        var result = new ResultWrapper<Book>();
        
        var basePath = configuration.GetValue<string>("AbertaApi:BaseUrl"); 
        var request =
            await requests.GetAsync<ResultWrapper<Book>>(
                $"{basePath}single?isbn={isbn}");

        if (request == null)
        {
            return new ResultWrapper<Book>();
        }
        
        if (request.IsSuccessful)
        {
            result.Data = request.Data;
            result.IsSuccessful = true;
            return result;
        }

        result.Errors.Add("Couldn't retrieve book");
        return result;
    }

    public async Task<ResultWrapper<BookDto>> GetBooks(int records, int page, bool isActive)
    {
        var result = new ResultWrapper<BookDto>();

        var search = new Search()
        {
            Page = page,
            NumberOfResults = records,

            SortBy = "alpha",
            SortOrder = "asc",
            SearchTerm = ""
        };

        var basePath = configuration.GetValue<string>("AbertaApi:BaseUrl");
        var active = isActive ? "active" : "inactive";
        var res =
            await requests.PostJsonAsync<ResultWrapper<BookDto>>(
                $"{basePath}all/{active}", search);

        if (res == null)
        {
            return new ResultWrapper<BookDto>();
        }
        
        if (res.IsSuccessful)
        {
            result.Data = res.Data;
            result.IsSuccessful = true;
            
            return result;
        }
        
        result.Data.Results = [];

        result.Errors.Add("Couldn't retrieve books");
        return result;
    }

    public async Task<ResultWrapper<List<Book>>> GetBooksSearch(string search, int records, int page, bool isActive)
    {
        var result = new ResultWrapper<List<Book>>();

        var bookSearch = new Search()
        {
            Page = page,
            NumberOfResults = records,

            SortBy = "alpha",
            SortOrder = "asc",
            SearchTerm = search
        };

        var basePath = configuration.GetValue<string>("AbertaApi:BaseUrl"); 
        var active = isActive ? "active" : "inactive";
        var request =
            await requests.PostJsonAsync<ResultWrapper<BookDto>>(
                $"{basePath}all/{active}", bookSearch);

        if (request == null)
        {
            return new ResultWrapper<List<Book>>();
        }
        
        if (request.IsSuccessful)
        {
            result.Data = request.Data.Results;
            result.IsSuccessful = true;
            return result;
        }
        
        result.Errors.Add("Couldn't retrieve books");
        return result;
    }

    public async Task<ResultWrapper<Book>> UpdateBook(Book book)
    {
        var result = new ResultWrapper<Book>();

        var basePath = configuration.GetValue<string>("AbertaApi:BaseUrl"); 
        var request = await requests.PostJsonAsync<ResultWrapper<Book>>(basePath + "update", book);

        if (request.IsSuccessful)
        {
            result.IsSuccessful = true;
            result.Data = request.Data;
            return result;
        }

        result.Errors.Add("Couldn't update book");
        return result;
    }
}