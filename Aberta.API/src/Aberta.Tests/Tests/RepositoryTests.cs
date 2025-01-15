using AbertaApi.Models;
using AbertaApi.Repositories;
using Microsoft.Extensions.Configuration;
using NSubstitute;

namespace Aberta.Tests;

public class RepositoryTests
{
    private readonly IConfiguration _configuration;
    public RepositoryTests()
    {
        _configuration = Substitute.For<IConfiguration>();
        _configuration.GetConnectionString("Database")
            .Returns("Host=localhost;Port=3308;Database=AbertaTest;Username=root;Password=P4sSw0+rd@");
    }
    
    [Fact]
    public async Task InsertTest()
    {
        BookRepository repository = new BookRepository(_configuration);

        Book actualBook = new Book
        {
            Id = "1",
            Isbn = "9789720046673",
            Title = "As intermitências da morte",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "",
            Synopsis = "",
            Price = 0,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014-01-01"
        };

        await repository.CreateBook(actualBook);
        ResultWrapper<Book> book = repository.GetBook("9789720046673");

        if (book != null)
            await repository.DeleteBook(book.Data);
        else
            Assert.Fail("That didnt go well");

        ResultWrapper<Book> newBook = repository.GetBook("9789720046673");

        Assert.True(!newBook.IsSuccessful);
    }

    [Fact]
    public async Task GetBookTest()
    {
        BookRepository repository = new BookRepository(_configuration);

        Book actualBook = new Book
        {
            Id = "1",
            Isbn = "9789720046673",
            Title = "As intermitências da morte",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "",
            Synopsis = "",
            Price = 0,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014-01-01"
        };

        await repository.CreateBook(actualBook);
        ResultWrapper<Book> book = repository.GetBook("9789720046673");

        if (book != null)
            await repository.DeleteBook(book.Data);
        else
            Assert.Fail("That didnt go well");

        Assert.True(book.Data != null);
    }

    [Fact]
    public async Task DeleteTest()
    {
        BookRepository repository = new BookRepository(_configuration);

        Book actualBook = new Book
        {
            Id = "1",
            Isbn = "9789720046673",
            Title = "As intermitências da morte",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "",
            Synopsis = "",
            Price = 0,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014-01-01"
        };

        await repository.CreateBook(actualBook);
        ResultWrapper<Book> book = repository.GetBook("9789720046673");
        await repository.DeleteBook(book.Data);
        ResultWrapper<Book> bookDelete = repository.GetBook("9789720046673");

        Assert.True(bookDelete.Data == null);
    }

    [Fact]
    public async Task UpdateTest()
    {
        BookRepository repository = new BookRepository(_configuration);

        Book actualBook = new Book
        {
            Id = "1",
            Isbn = "9789720046673",
            Title = "As intermitências da morte",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "",
            Synopsis = "",
            Price = 0,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014-01-01"
        };

        await repository.CreateBook(actualBook);
        ResultWrapper<Book> book = repository.GetBook("9789720046673");

        if (book.Data != null)
        {
            book.Data.Title = "test";
            await repository.UpdateBook(book.Data);
            ResultWrapper<Book> updatedBook = repository.GetBook("9789720046673");
            Assert.True(updatedBook.Data.Title == "test");
            
            await repository.DeleteBook(updatedBook.Data);
        }
        else
        {
            Assert.Fail("The book was null");
        }
    }

    [Fact]
    public async void GetBooksTest()
    {
        BookRepository repository = new BookRepository(_configuration);

        Book actualBook = new Book
        {
            Id = "9789720046673",
            Isbn = "9789720046673",
            Title = "As intermitências da morte",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "",
            Synopsis = "",
            Price = 0,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014-01-01"
        };
        
        Book diffBook = new Book
        {
            Id = "000000000001",
            Isbn = "000000000001",
            Title = "Fantasias",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "",
            Synopsis = "",
            Price = 0,
            Author = "Test author",
            Language = "Português",
            ReleaseDate = "1980-01-01"
        };

        List<Book> bookData = new List<Book>() { diffBook, actualBook };

        foreach (var book in bookData)
        {
            await repository.CreateBook(book);
        }

        ResultWrapper<List<Book>> books = repository.GetBooks(b => b.Title.Contains("morte"), 20, 0);

        if (books.Data is not { Count: > 0 })
        {
            Assert.Fail();
            return;
        }

        foreach (var book in bookData)
        {
            await repository.DeleteBook(book);
        }

        bool isResultCorrect = true;
        foreach (var book in books.Data)
        {
            if (!book.Title.Contains("morte") && !book.Author.Contains("morte") && !book.Isbn.Contains("morte"))
                isResultCorrect = false;
        }

        Assert.True(isResultCorrect);
    }
}
