using Aberta.API.Repositories;
using Aberta.Tests.Content;
using AbertaApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace Aberta.Tests;

public class RepositoryTests
{
    private readonly IConfiguration _configuration;
    private readonly BookRepository _bookRepository;

    public RepositoryTests()
    {
        _configuration = Substitute.For<IConfiguration>();
        _configuration.GetConnectionString("Database")
            .Returns("Host=localhost;Port=3308;Database=AbertaTest;Username=root;Password=P4sSw0+rd@");

        var serviceProvider = new ServiceCollection()
            .AddLogging()
            .BuildServiceProvider();
        var factory = serviceProvider.GetService<ILoggerFactory>();
        var logger = factory.CreateLogger<BookRepository>();
        
        _bookRepository = new BookRepository(_configuration, logger);
    }

    [Theory]
    [InlineData("9780008637569")]
    [InlineData("9789720046673")]
    public async Task InsertValidBooks(string isbn)
    {
        var actualBook = Books.GetBooks().FirstOrDefault(book => book.Isbn == isbn);

        var result = await _bookRepository.CreateBook(actualBook);

        Assert.True(result.IsSuccessful);
        await CleanUp();
    }

    [Fact]
    public async Task GetBookTest()
    {
        var actualBook = Books.GetBooks()[0];

        await _bookRepository.CreateBook(actualBook);
        var book = _bookRepository.GetBook(actualBook.Isbn);

        Assert.True(book.IsSuccessful);
        
        await CleanUp();
    }

    [Fact]
    public async Task DeleteTest()
    {
        var actualBook = Books.GetBooks()[0];

        await _bookRepository.CreateBook(actualBook);
        var result = await _bookRepository.DeleteBook(actualBook);

        Assert.True(result.IsSuccessful);
        
        await CleanUp();
    }

    [Fact]
    public async Task UpdateTest()
    {
        var actualBook = Books.GetBooks()[0];
        var updatedBook = Books.GetUpdatedBooks()[0];

        await _bookRepository.CreateBook(actualBook);
        var book = _bookRepository.GetBook(actualBook.Isbn);
        
        book.Data.Price = updatedBook.Price;
        book.Data.Publisher = updatedBook.Publisher;
        book.Data.Author = updatedBook.Author;
        book.Data.Stock = updatedBook.Stock;

        if (book.IsSuccessful)
        {
            var result = await _bookRepository.UpdateBook(book.Data);
            Assert.True(result.IsSuccessful);
        }
        else
        {
            Assert.Fail("The book was not found.");
        }
        
        await CleanUp();
    }

    [Theory]
    [InlineData("morte")]
    public async Task GetBooksByTitle(string textInput)
    {
        string text = textInput.ToLower();
        var bookData = Books.GetBooks().Where(book => book.Title.ToLower().Contains(text));

        foreach (var book in bookData)
        {
            await _bookRepository.CreateBook(book);
        }

        var books = _bookRepository.GetBooksByTitle(text);

        if (!books.IsSuccessful)
        {
            Assert.Fail();
            return;
        }

        var retrievedBooksCount = books.Data.Count;
        var bookCountWithTitleKeyword = Books.GetBooks().Count(book => book.Title.ToLower().Contains(text));
        Assert.True(retrievedBooksCount == bookCountWithTitleKeyword);
        
        await CleanUp();
    }
    
    [Theory]
    [InlineData("Sara")]
    [InlineData("Michae")]
    public async Task GetBooksByAuthor(string textInput)
    {
        string text = textInput.ToLower();
        var bookData = Books.GetBooks().Where(book => book.Author.ToLower().Contains(text));

        foreach (var book in bookData)
        {
            await _bookRepository.CreateBook(book);
        }

        var books = _bookRepository.GetBooksByAuthor(text);

        if (!books.IsSuccessful)
        {
            Assert.Fail();
            return;
        }

        var retrievedBooksCount = books.Data.Count;
        var bookCountWithTitleKeyword = Books.GetBooks().Count(book => book.Author.ToLower().Contains(text));
        Assert.True(retrievedBooksCount == bookCountWithTitleKeyword);
        
        await CleanUp();
    }
    
    [Theory]
    [InlineData("9780008637569")]
    public async Task GetBooksByIsbn(string textInput)
    {
        string text = textInput.ToLower();
        var bookData = Books.GetBooks().Where(book => book.Isbn.ToLower().Contains(text));

        foreach (var book in bookData)
        {
            await _bookRepository.CreateBook(book);
        }

        var books = _bookRepository.GetBooksByIsbn(text);

        if (!books.IsSuccessful)
        {
            Assert.Fail();
            return;
        }

        var retrievedBooksCount = books.Data.Count;
        var bookCountWithTitleKeyword = Books.GetBooks().Count(book => book.Isbn.ToLower().Contains(text));
        Assert.True(retrievedBooksCount == bookCountWithTitleKeyword);
        
        await CleanUp();
    }

    private async Task CleanUp()
    {
        var ctx = new Context(_configuration.GetConnectionString("Database"));
        await ctx.Books.ExecuteDeleteAsync();
        await ctx.SaveChangesAsync();
    }
}