using AbertaApi.Contracts.Repositories;
using AbertaApi.Contracts.Services;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;

namespace Aberta.API.Services;

public class BookService(
    IBookRepository repo,
    ITagService tagService,
    IBnpLibraryService bnpService,
    IOpenLibraryService olService,
    ILogger<BookService> logger) : IBookService
{
    #region CRUD

    public async Task<ResultWrapper<Book>> UpdateBook(Book book)
    {
        var result = new ResultWrapper<Book>();

        logger.LogInformation("Validating book to update.");

        var errors = ValidateBook(book);
        if (errors.Count > 0)
        {
            result.Errors.AddRange(errors);
            return result;
        }

        if (book.Isbn == null) return result;
        var fetchedBook = repo.GetBook(book.Isbn);

        if (fetchedBook.IsSuccessful)
        {
            fetchedBook.Data = UpdateBook(book, fetchedBook.Data);
            if (book.TagsList != null)
                if (fetchedBook.Data.TagsList != null)
                    fetchedBook.Data.TagsList = UpdateTags(book.TagsList, fetchedBook.Data.TagsList);

            result = await repo.UpdateBook(fetchedBook.Data);

            if (!result.IsSuccessful) return result;
            result.IsSuccessful = true;
        }
        else
        {
            result.Errors.Add("The book was not found.");
        }

        return result;
    }

    public async Task<ResultWrapper<Book>> CreateBook(Book book)
    {
        var result = new ResultWrapper<Book>();

        try
        {
            logger.LogInformation("Validating book to create.");

            var errors = ValidateBook(book);

            if (errors.Count > 0)
            {
                result.IsSuccessful = false;
                result.Errors = errors;
                return result;
            }

            if (book.Isbn == null) return result;

            var fetchedBook = repo.GetBook(book.Isbn);

            if (!fetchedBook.IsSuccessful)
            {
                result = await repo.CreateBook(book);
            }
            else
            {
                result.Errors.Add("The book already exists.");
            }

            return result;
        }
        catch (Exception e)
        {
            result.Errors.Add("Something went wrong.");
            logger.LogError(e.Message, e);
            return result;
        }
    }

    public ResultWrapper<Book> GetBook(string isbn)
    {
        var result = new ResultWrapper<Book>();

        try
        {
            result = repo.GetBook(isbn);
        }
        catch (Exception e)
        {
            result.Errors.Add("Something went wrong.");
            logger.LogError(e.Message, e);
            return result;
        }

        return result;
    }

    public async Task<ResultWrapper<Book>> DeleteBook(string isbn)
    {
        var result = new ResultWrapper<Book>();

        try
        {
            var booksToDelete = repo.GetBook(isbn);
            var bookToDelete = booksToDelete.Data;

            if (booksToDelete.IsSuccessful)
            {
                await repo.DeleteBook(bookToDelete);
                result.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    #endregion

    public ResultWrapper<BookResults> SearchBooks(BookSearch search, bool isActive)
    {
        var books = new ResultWrapper<BookResults>();
        
        try
        {
            List<Book> booksList = [];

            logger.LogInformation("Searching books...");
            
            // get all books unfiltered
            var booksArr = repo.GetBooks(isActive);

            if (string.IsNullOrEmpty(search.SearchTerm))
            {
                booksList = booksArr.Data;
            }
            else
            {
                // get books by title first
                var booksTitle = booksArr.Data.Where(book =>
                    book.Title != null && book.Title.ToLower().Contains(search.SearchTerm.ToLower())).ToList();
                
                var booksAuthor = booksArr.Data.Where(book =>
                    book.Author != null && book.Author.ToLower().Contains(search.SearchTerm.ToLower())).ToList();
                
                var booksPublisher = booksArr.Data.Where(book =>
                    book.Publisher != null && book.Publisher.ToLower().Contains(search.SearchTerm.ToLower())).ToList();
                
                var booksTranslator = booksArr.Data.Where(book =>
                    book.Translator != null && book.Translator.ToLower().Contains(search.SearchTerm.ToLower())).ToList();
                
                var booksISBN = booksArr.Data.Where(book =>
                    book.Isbn != null && book.Isbn.ToLower().Contains(search.SearchTerm.ToLower())).ToList();
                
                // order lists by the amount of records it got back
                var tmpList = 
                    new List<List<Book>>([booksTitle, booksAuthor, booksPublisher, booksTranslator, booksISBN])
                        .OrderByDescending(lists => lists.Count).ToList();
                
                booksList.AddRange(tmpList[0]);
                booksList.AddRange(tmpList[1]);
                booksList.AddRange(tmpList[2]);
                booksList.AddRange(tmpList[3]);
                booksList.AddRange(tmpList[4]);
                
                booksList = booksList.Distinct().ToList();
            }

            if (search.Tags is { Count: > 0 })
            {
                booksList = booksList.Where(book =>
                        book.TagsList != null && book.TagsList
                            .Any(tagInBook => search.Tags.Contains(tagInBook.Name)))
                    .ToList();
            }

            if (booksList is { Count: > 0 })
            {
                books.IsSuccessful = true;

                var bookResults = new BookResults
                {
                    Results = booksList
                        .Skip((search.Page - 1) * search.NumberOfResults)
                        .Take(search.NumberOfResults)
                        .ToList(),
                    AmountOfResults = booksList.Count,
                    TotalPages = (booksList.Count / search.NumberOfResults) + 1,
                    CurrentPage = search.Page
                };

                books.Data = bookResults;
            }
        }
        catch (Exception e)
        {
            books.Errors.Add("Something went wrong.");
            logger.LogError(e.Message);
        }

        return books;
    }

    public async Task<ResultWrapper<Book>> GetLibraryBook(string isbn, ApiService library)
    {
        var book = new ResultWrapper<Book>();

        try
        {
            switch (library)
            {
                case ApiService.OpenLibrary:
                    book = await olService.GetBook(isbn);
                    break;
                case ApiService.BibliotecaNacionalPortuguesa:
                    book = await bnpService.GetBook(isbn);
                    break;
            }

            book.IsSuccessful = true;
        }
        catch (Exception e)
        {
            book.Errors.Add("Something went wrong.");
            logger.LogError(e.Message, e);
        }

        return book;
    }

    private static List<string> ValidateBook(Book book)
    {
        List<string> errors = [];

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

        return errors;
    }

    private static Book UpdateBook(Book newBook, Book bookToUpdate)
    {
        if (!string.IsNullOrEmpty(newBook.Title))
            bookToUpdate.Title = newBook.Title;

        if (!string.IsNullOrEmpty(newBook.Synopsis))
            bookToUpdate.Synopsis = newBook.Synopsis;

        if (!string.IsNullOrEmpty(newBook.Author))
            bookToUpdate.Author = newBook.Author;

        if (!string.IsNullOrEmpty(newBook.Publisher))
            bookToUpdate.Publisher = newBook.Publisher;

        if (!string.IsNullOrEmpty(newBook.Language))
            bookToUpdate.Language = newBook.Language;

        if (!string.IsNullOrEmpty(newBook.Translator))
            bookToUpdate.Translator = newBook.Translator;
        
        if (!string.IsNullOrEmpty(newBook.ReleaseDate))
            bookToUpdate.ReleaseDate = newBook.ReleaseDate;
        
        if (!string.IsNullOrEmpty(newBook.CoverPicture))
            bookToUpdate.CoverPicture = newBook.CoverPicture;

        bookToUpdate.IsActive = newBook.IsActive;

        bookToUpdate.Price = newBook.Price;

        bookToUpdate.Stock = newBook.Stock;


        return bookToUpdate;
    }

    private List<Tag> UpdateTags(List<Tag> newTags, List<Tag> tagsToUpdate)
    {
        #region REMOVE TAGS THAT WERE DELETE

        var tagsToRemove = tagsToUpdate.Where(tag =>
            newTags.All(t => !t.Name.Equals(tag.Name, StringComparison.CurrentCultureIgnoreCase))).ToList();

        foreach (var tagToRemove in tagsToRemove)
        {
            tagsToUpdate.Remove(tagToRemove);
        }

        #endregion

        foreach (var newTag in newTags)
        {
            var tagsInBook =
                tagsToUpdate.Where(t => t.Name.Equals(newTag.Name, StringComparison.CurrentCultureIgnoreCase));

            if (tagsInBook.Any()) continue;

            var tagInDb = tagService.GetActiveTags(newTag.Name);

            tagsToUpdate.Add(tagInDb is { IsSuccessful: true, Data.Count: > 0 } ? tagInDb.Data.First() : newTag);
        }

        return tagsToUpdate;
    }
}