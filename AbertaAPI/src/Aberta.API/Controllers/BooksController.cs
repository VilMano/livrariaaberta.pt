using AbertaApi.Contracts.Services;
using AbertaApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aberta.API.Controllers;

[Route("[controller]")]
[ApiController]
public class BooksController(IBookService bs, IVendusService vendusService) : ControllerBase
{
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("single")]
    public IActionResult GetBook(string isbn)
    {
        var result = bs.GetBook(isbn);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    // [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("all/inactive")]
    public IActionResult GetInactiveBooks(BookSearch search)
    {
        var result = new ResultWrapper<BookResults>();
        
        result = bs.SearchBooks(search, false);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
    
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("all/active")]
    public IActionResult GetActiveBooks(BookSearch search)
    {
        var result = new ResultWrapper<BookResults>();
        
        result = bs.SearchBooks(search, true);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    // [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("update")]
    public async Task<IActionResult> UpdateBook(Book book)
    {
        var result = await bs.UpdateBook(book);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
    
    // [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("create")]
    public async Task<IActionResult> CreateBook(Book book)
    {
        var result = await bs.CreateBook(book);

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
        var result = await bs.DeleteBook(isbn);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpGet("ol")]
    public async Task<IActionResult> GetOpenLibraryBook(string isbn)
    {
        var result = await bs.GetLibraryBook(isbn, ApiService.OpenLibrary);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpGet("bnp")]
    public async Task<IActionResult> GetBnpBook(string isbn)
    {
        var result = await bs.GetLibraryBook(isbn, ApiService.BibliotecaNacionalPortuguesa);

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
        var result = await vendusService.GetBook(isbn);

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
        var result = await vendusService.GetBatchOfBookStock(numberOfResults, page);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
}