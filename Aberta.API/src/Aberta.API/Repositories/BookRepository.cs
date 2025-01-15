using AbertaApi.Contracts.Repositories;
using AbertaApi.Data;
using AbertaApi.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace AbertaApi.Repositories;

public class BookRepository : IBookRepository
{
    private readonly IConfiguration _configuration;
    private readonly DbContextOptionsBuilder<Context> _ctxOptions;

    public BookRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        var connectionString = _configuration.GetConnectionString("Database");
        _ctxOptions = new DbContextOptionsBuilder<Context>().UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString)
        );
    }

    public async Task<ResultWrapper<Book>> CreateBook(Book book)
    {
        Log.Information($"-------------------{book.Isbn}------------------------");
        Log.Information("Creating book...");
        ResultWrapper<Book> result = new ResultWrapper<Book>();

        using (var ctx = new Context(_ctxOptions.Options))
        {
            try
            {
                book.Id ??= book.Isbn;

                var res = await ctx.Books.AddAsync(book);
                await ctx.SaveChangesAsync();

                if (res != null && res.Entity != null)
                {
                    result.Data = res.Entity;
                    result.IsSuccessful = true;
                    
                    Log.Information("Book was successfully created.");
                }
                else
                {
                    string error = "No book was created.";
                    
                    Log.Error(error);
                    result.Errors.Add(error);
                }

            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                result.Errors.Add("An error occured.");
            }
        }

        return result;
    }

    public ResultWrapper<Book> GetBook(string isbn)
    {
        Log.Information($"-------------------{isbn}------------------------");
        Log.Information("Getting book...");
        ResultWrapper<Book> result = new ResultWrapper<Book>();

        using (var ctx = new Context(_ctxOptions.Options))
        {
            try
            {
                var res = ctx.Books.Where(book => book.Isbn == isbn)
                    .Include(b => b.TagsList);

                if (res?.FirstOrDefault() != null)
                {
                    result.Data = res.FirstOrDefault();
                    result.IsSuccessful = true;
                    
                    Log.Information("Book was successfully retrieved.");
                }
                else
                {
                    string error = "No book was found.";
                    
                    Log.Error(error);
                    result.Errors.Add(error);
                }
            }
            catch (Exception e)
            {
                result.Errors.Add("An error occured.");
                Log.Error(e.Message);
            }
        }

        return result;
    }

    public ResultWrapper<List<Book>> GetBooks(Func<Book, bool> expression, int records, int skip, bool orderDescending = false, Order orderBy = Order.Alphabetical)
    {
        Log.Information("Getting books...");
        
        ResultWrapper<List<Book>> result = new ResultWrapper<List<Book>>();
        List<Book> books = new List<Book>();
        using (var ctx = new Context(_ctxOptions.Options))
        {
            try
            {
                if (orderDescending)
                {
                    switch (orderBy)
                    {
                        case Order.Alphabetical:
                            books = ctx.Books.Where(expression).OrderByDescending(b=> b.Title).Skip(skip).Take(records).ToList<Book>();
                            break;
                        case Order.Price:
                            books = ctx.Books.Where(expression).OrderByDescending(b=> b.Price).Skip(skip).Take(records).ToList<Book>();
                            break;
                        case Order.Date:
                            books = ctx.Books.Where(expression).OrderByDescending(b=> b.ReleaseDate).Skip(skip).Take(records).ToList<Book>();
                            break;
                    }
                }
                else
                {
                    switch (orderBy)
                    {
                        case Order.Alphabetical:
                            books = ctx.Books.Where(expression).OrderBy(b=> b.Title).Skip(skip).Take(records).ToList<Book>();
                            break;
                        case Order.Price:
                            books = ctx.Books.Where(expression).OrderBy(b=> b.Price).Skip(skip).Take(records).ToList<Book>();
                            break;
                        case Order.Date:
                            books = ctx.Books.Where(expression).OrderBy(b=> b.ReleaseDate).Skip(skip).Take(records).ToList<Book>();
                            break;
                    }
                }

                if (books is {Count: > 0})
                {
                    Log.Information("Books successfully retrieved.");
                    result.Data = books;
                    result.IsSuccessful = true;
                }
                else
                {
                    Log.Information("No books were retrieved.");
                    result.Errors.Add("No books were retrieved.");
                }

                return result;
            }
            catch (Exception e)
            {
                result.Errors.Add("Something went wrong.");
                Log.Error(e.Message);
            }
        }

        return result;
    }

    public async Task<ResultWrapper<Book>> UpdateBook(Book book)
    {
        Log.Information($"-------------------{book.Isbn}------------------------");
        Log.Information("Updating book...");
        ResultWrapper<Book> result = new ResultWrapper<Book>();

        using (var ctx = new Context(_ctxOptions.Options))
        {
            try
            {
                if (book != null)
                {
                    var res = ctx.Books.Update(book);
                    await ctx.SaveChangesAsync();

                    if (res is { Entity: not null })
                    {
                        result.Data = res.Entity;
                        result.IsSuccessful = true;
                        
                        Log.Information("Book successfully updated.");
                    }
                    else
                    {
                        string error = "Could not update the book.";
                        
                        Log.Error(error);
                        result.Errors.Add(error);
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                result.Errors.Add("Something went wrong.");
            }
        }

        return result;
    }

    public async Task<ResultWrapper<Book>> DeleteBook(Book book)
    {
        Log.Information($"-------------------{book.Isbn}------------------------");
        Log.Information("Deleting book...");
        ResultWrapper<Book> result = new ResultWrapper<Book>();

        using (var ctx = new Context(_ctxOptions.Options))
        {
            try
            {
                ctx.Books.Remove(book);
                await ctx.SaveChangesAsync();
                
                Log.Information("Deleted book successfully.");
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                result.Errors.Add("Something went wrong.");
            }
        }

        return result;
    }
}
