using AbertaApi.Contracts.Repositories;
using AbertaApi.Contracts.Services;
using AbertaApi.Models;
using AbertaApi.Contracts.Services.Libraries;
using Newtonsoft.Json;
using Serilog;

namespace AbertaApi.Services;

public class BookService(IBookRepository repo, ITagService tagService, IBnpLibraryService bnpService, IOpenLibraryService olService)
    : IBookService
{
    #region CRUD

    public async Task<ResultWrapper<Book>> UpdateBook(Book book)
    {
        ResultWrapper<Book> result = new ResultWrapper<Book>();
        
        List<string> errors = ValidateBook(book);

        if (errors.Count != 0)
        {
            result.Errors = errors;
            result.IsSuccessful = false;
            return result;
        }
        
        ResultWrapper<Book> fetchedBook = repo.GetBook(book.Isbn);

        if (fetchedBook.Data == null)
        {
            result.Errors.Add("The book was not found.");
            result.IsSuccessful = false;
            return result;
        }

        try
        {
            List<Tag> newTagList = [];
            foreach(Tag tag in book.TagsList){
                Tag currentTag = tagService.GetActiveTags(tag.Name).Data.FirstOrDefault();

                if(currentTag != null)
                {
                    var tags = newTagList.Where(t => t.Name.ToLowerInvariant() == currentTag.Name.ToLowerInvariant()).ToList();
                    if(tags.Count() == 0)
                        newTagList.Add(currentTag);
                }else{
                    ResultWrapper<Tag> newTagRes = await tagService.CreateTag(tag);
                    Tag newTag = new Tag{
                        Id = newTagRes.Data.Id,
                        Name = newTagRes.Data.Name
                    };
                    newTagList.Add(newTag);
                }
            }

            book.TagsList = newTagList;

            result = await repo.UpdateBook(book);
        }
        catch (Exception e)
        {
            result.Errors.Add("Something went wrong.");
            Log.Error(e.Message);
        }

        return result;
    }

    public async Task<ResultWrapper<Book>> CreateBook(Book book)
    {
        ResultWrapper<Book> result = new ResultWrapper<Book>();

        try
        {
            List<string> errors = ValidateBook(book);

            if (errors.Any())
            {
                result.IsSuccessful = false;
                result.Errors = errors;
                return result;
            }

            ResultWrapper<Book> fetchedBook = repo.GetBook(book.Isbn);

            if (fetchedBook.Data == null)
            {
                result = await repo.CreateBook(book);
            }
            else
            {
                result.IsSuccessful = false;
                result.Errors.Add("The book already exists.");
                return result;
            }
        }
        catch (Exception e)
        {
            result.Errors.Add("Something went wrong.");
            Log.Error(e.Message);
        }

        return result;
    }

    public ResultWrapper<Book> GetBook(string isbn)
    {
        ResultWrapper<Book> result = new ResultWrapper<Book>();

        try
        {
            result = repo.GetBook(isbn);

            if (result.IsSuccessful)
            {
                return result;
            }
        }
        catch (Exception e)
        {
            result.Errors.Add("Something went wrong.");
            Log.Error(e.Message);
        }

        return result;
    }

    // orderQuery = "desc/asc,alpha/price/date"
    public ResultWrapper<BookResults> GetBooks(int numberOfRecords, int page, string orderQuery = "desc,alpha")
    {
        ResultWrapper<BookResults> result = new ResultWrapper<BookResults>();

        int skip = (page - 1) * numberOfRecords;

        try
        {
            Order orderResults = Order.Alphabetical;
            bool isDescending = orderQuery.Split(',')[0] == "desc";

            switch (orderQuery.Split(',')[1])
            {
                case "price":
                    orderResults = Order.Price;
                    break;
                case "date":
                    orderResults = Order.Date;
                    break;
            }

            ResultWrapper<List<Book>> books =
                repo.GetBooks(b => b.isActive, numberOfRecords, skip, isDescending, orderResults);
            ResultWrapper<List<Book>> totalBookCount = repo.GetBooks(book => book.isActive, 100000, 0);

            result.Data = new BookResults();
            result.Data.results = books.Data;
            result.Data.AmmountOfResults = totalBookCount.Data.Count;
            result.Data.CurrentPage = page;
            result.Data.TotalPages = totalBookCount.Data.Count / numberOfRecords;
            result.IsSuccessful = true;

            if (result.IsSuccessful)
            {
                return result;
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public async Task<ResultWrapper<Book>> DeleteBook(string isbn)
    {
        ResultWrapper<Book> result = new ResultWrapper<Book>();
        try
        {
            ResultWrapper<Book> booksToDelete = repo.GetBook(isbn);
            Book bookToDelete = booksToDelete.Data;

            if (bookToDelete != null && !string.IsNullOrEmpty(bookToDelete.Isbn))
            {
                await repo.DeleteBook(bookToDelete);
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    #endregion

    public async Task<ResultWrapper<BookResults>> SearchBooksByTitleAndOtherAttributes(string attributes,
        int numberOfRecords = 50, int page = 1)
    {
        ResultWrapper<BookResults> books = new ResultWrapper<BookResults>();

        try
        {
            List<Book> booksList = new List<Book>();

            // start retrieving values from the database
            var booksByTitle = repo.GetBooks(book => Utils.StringContains(book.Title, attributes), 10000, 0);
            var booksByAuthor =
                repo.GetBooks(book => book.Author != null && Utils.StringContains(book.Author, attributes), 10000, 0);
            var booksByIsbn = repo.GetBooks(book => Utils.StringContains(book.Isbn, attributes), 10000, 0);

            if (booksByTitle.Data is { Count: > 0 })
                booksList.AddRange(booksByTitle.Data);

            if (booksByAuthor.Data is { Count: > 0 })
                booksList.AddRange(booksByAuthor.Data);

            if (booksByIsbn.Data is { Count: > 0 })
                booksList.AddRange(booksByIsbn.Data);

            if (booksList is { Count: > 0 })
            {
                books.IsSuccessful = true;

                BookResults BookResults = new BookResults();
                BookResults.results = booksList.Skip((page - 1) * numberOfRecords).Take(numberOfRecords).ToList();
                BookResults.AmmountOfResults = booksList.Count;
                BookResults.TotalPages = (booksList.Count / numberOfRecords) + 1;
                BookResults.CurrentPage = page;

                books.Data = BookResults;
            }
        }
        catch (Exception e)
        {
            books.Errors.Add("Something went wrong.");
            Log.Error(e.Message);
        }

        return books;
    }

    public async Task<ResultWrapper<Book>> GetLibrarBook(string isbn, ApiService api)
    {
        ResultWrapper<Book> book = new ResultWrapper<Book>();

        try
        {
            switch (api)
            {
                case ApiService.OpenLibrary:
                    book = await olService.GetBook(isbn);
                    break;
                case ApiService.BibliotecaNacionalPortuguesa:
                    book = await bnpService.GetBook(isbn);
                    break;
            }

            if (book.Data != null)
                book.IsSuccessful = true;
        }
        catch (Exception e)
        {
            book.Errors.Add("Something went wrong.");
            Log.Error(e.Message);
        }

        return book;
    }

    public List<string> ValidateBook(Book book)
    {
        List<string> errors = [];

        if (book != null)
        {
            if (book.Isbn == null || string.IsNullOrEmpty(book.Isbn))
            {
                errors.Add("ISBN is required.");
            }

            if (book.Title == null || string.IsNullOrEmpty(book.Title))
            {
                errors.Add("Title is required.");
            }

            if (book.Author == null || string.IsNullOrEmpty(book.Author))
            {
                errors.Add("Author is required.");
            }
        }
        else
        {
            errors.Add("Book object is required.");
        }

        return errors;
    }
}