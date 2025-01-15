using AbertaApi.Contracts.Services;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AbertaApi.Controllers;

[Route("[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bs;
    private readonly IVendusService _vendusService;

    public BooksController(IBookService bs, IVendusService vendusService)
    {
        _bs = bs;
        _vendusService = vendusService;
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("single")]
    public async Task<IActionResult> GetBook(string isbn)
    {
        ResultWrapper<Book> result = _bs.GetBook(isbn);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("all")]
    public async Task<IActionResult> GetBooks(BookSearch search)
    {
        ResultWrapper<BookResults> result = new ResultWrapper<BookResults>();
        
        if (string.IsNullOrEmpty(search.SearchTerm))
        {
            string orderBy = search.SortOrder;
            string sortBy = search.SortBy;

            string order = $"{sortBy},{orderBy}";
            
            result = _bs.GetBooks(search.NumberOfResults, search.Page, order);
            
            if (result.IsSuccessful)
            {
                return Ok(result);
            }
        }
        else
        {
            result = await _bs.SearchBooksByTitleAndOtherAttributes(search.SearchTerm, search.NumberOfResults, search.Page);

            if (result.IsSuccessful)
            {
                return Ok(result);
            }
        }
        
        return BadRequest(result);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("update")]
    public async Task<IActionResult> CreateOrUpdateBook(Book book)
    {
        ResultWrapper<Book> result = await _bs.UpdateBook(book);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
    
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("create")]
    public async Task<IActionResult> CreateBook(Book book)
    {
        ResultWrapper<Book> result = await _bs.CreateBook(book);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpDelete("remove")]
    public async Task<IActionResult> DeleteBook(string isbn)
    {
        ResultWrapper<Book> result = await _bs.DeleteBook(isbn);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpGet("ol")]
    public async Task<IActionResult> GetOpenLibraryBook(string isbn)
    {
        ResultWrapper<Book> result = await _bs.GetLibrarBook(isbn, ApiService.OpenLibrary);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpGet("bnp")]
    public async Task<IActionResult> GetBnpBook(string isbn)
    {
        ResultWrapper<Book> result = await _bs.GetLibrarBook(isbn, ApiService.BibliotecaNacionalPortuguesa);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("vendus")]
    public async Task<IActionResult> GetVendusBook(string isbn)
    {
        ResultWrapper<Book> result = await _vendusService.GetBook(isbn);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("vendus/batch")]
    public async Task<IActionResult> GetVendusBooks(int numberOfResults, int page)
    {
        ResultWrapper<List<Book>> result = await _vendusService.GetBatchOfBookStock(numberOfResults, page);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
}