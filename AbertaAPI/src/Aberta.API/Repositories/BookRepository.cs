using AbertaApi.Contracts.Repositories;
using AbertaApi.Data;
using AbertaApi.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Aberta.API.Repositories;

public class BookRepository : IBookRepository
{
    private readonly IConfiguration _configuration;
    private readonly Context _context;
    private readonly ILogger<BookRepository> _logger;
    public BookRepository(IConfiguration configuration, ILogger<BookRepository> logger)
    {
        _configuration = configuration;

        _context = new Context(_configuration.GetConnectionString("Database"));
        _logger = logger;
    }
    public async Task<ResultWrapper<Book>> CreateBook(Book book)
    {
        _logger.LogInformation("Creating book...");
        var result = new ResultWrapper<Book>();

        try
        {
            book.Id ??= book.Isbn;

            var res = await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            if (res != null && res.Entity != null)
            {
                result.Data = res.Entity;
                result.IsSuccessful = true;

                _logger.LogInformation("Book was successfully created.");
            }
            else
            {
                const string error = "No book was created.";

                _logger.LogError(error);
                result.Errors.Add(error);
            }
        }
        catch (Exception e)
        {
            _logger.LogError(message: e.Message, e);
            result.Errors.Add("An error occured.");
            return result;
        }
        finally
        {
            _logger.LogInformation("Finished creating book.");
        }
        
        return result;
    }

    public ResultWrapper<Book> GetBook(string isbn)
    {
        _logger.LogInformation("Getting book...");
        var result = new ResultWrapper<Book>();

        try
        {
            var res = _context.Books.Where(book => book.Isbn == isbn)
                .Include(b => b.TagsList);

            if (res?.FirstOrDefault() != null)
            {
                result.Data = res.FirstOrDefault();
                result.IsSuccessful = true;

                _logger.LogInformation("Book was successfully retrieved.");
            }
            else
            {
                const string error = "No book was found.";
                
                _logger.LogError(error);
                result.Errors.Add(error);
            }
        }
        catch (Exception e)
        {
            result.Errors.Add("An error occured.");
            _logger.LogError(message: e.Message, e);
            
            return result;
        }
        finally
        {
            _logger.LogInformation("Finished getting book.");
        }

        return result;
    }
    
    public ResultWrapper<List<Book>> GetBooks(bool isActive)
    {
        _logger.LogInformation("Getting active books...");

        var result = new ResultWrapper<List<Book>>();

        var books = new List<Book>();
        try
        {
            books = _context.Books.Where(book => book.IsActive == isActive).Include(b => b.TagsList).ToList();

            if (books is { Count: > 0 })
            {
                _logger.LogInformation("Books successfully retrieved.");
                result.Data = books;
                result.IsSuccessful = true;
            }
            else
            {
                const string error = "No books were retrieved.";
                
                _logger.LogError(error);
                result.Errors.Add(error);
            }
        }
        catch (Exception e)
        {
            result.Errors.Add("Something went wrong.");
            Log.Error(e.Message);
            return result;
        }
        finally
        {
            _logger.LogInformation("Finished getting active books.");
        }
        
        return result;
    }

    public async Task<ResultWrapper<Book>> UpdateBook(Book book)
    {
        _logger.LogInformation("Updating book...");
        var result = new ResultWrapper<Book>();

        try
        {
            if (book != null)
            {
                var res = _context.Books.Update(book);
                await _context.SaveChangesAsync();

                if (res is { Entity: not null })
                {
                    result.Data = res.Entity;
                    result.IsSuccessful = true;

                    _logger.LogInformation("Book successfully updated.");
                }
                else
                {
                    const string error = "Could not update the book.";

                    _logger.LogError(error);
                    result.Errors.Add(error);
                }
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }
        finally
        {
            _logger.LogInformation("Finished updating book.");
        }
        
        return result;
    }

    public async Task<ResultWrapper<Book>> DeleteBook(Book book)
    {
        _logger.LogInformation("Deleting book...");
        var result = new ResultWrapper<Book>();

        try
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            result.IsSuccessful = true;

            _logger.LogInformation("Deleted book successfully.");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
            
            return result;
        }
        finally
        {
            _logger.LogInformation("Finished deleting book.");
        }

        return result;
    }
}