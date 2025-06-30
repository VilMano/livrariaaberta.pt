using Aberta.API.Services;
using Aberta.Tests.Content;
using AbertaApi.Contracts.Repositories;
using AbertaApi.Contracts.Services;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;
using NSubstitute;

namespace Aberta.Tests;

public class ServiceTests
{
    private readonly IBookRepository _bookRepository = Substitute.For<IBookRepository>();
    private readonly ITagService _tagService = Substitute.For<ITagService>();
    private readonly IBnpLibraryService _bnpLibraryService = Substitute.For<IBnpLibraryService>();
    private readonly IOpenLibraryService _openLibraryService = Substitute.For<IOpenLibraryService>();

    [Fact]
    public async Task GetBook()
    {
        _bookRepository.GetBook("9789720046673").Returns(new ResultWrapper<Book>()
            { Data = Books.GetBooks()[0], IsSuccessful = true, Errors = [] });

        BookService bs = new BookService(_bookRepository, _tagService, _bnpLibraryService, _openLibraryService);

        ResultWrapper<Book> createdBook = bs.GetBook("9789720046673");

        
        string userMessage = createdBook.Errors is { Count: > 0 } ? createdBook.Errors[0] : "";
        Assert.True(createdBook.IsSuccessful, userMessage);
    }

    [Fact]
    public async Task CreateBook()
    {
        ResultWrapper<Book> returnBook = new ResultWrapper<Book>();
        Book actualBook = Books.GetBooks()[1];

        _bookRepository.GetBook(actualBook.Isbn).Returns(returnBook);
        _bookRepository.CreateBook(actualBook).Returns(new ResultWrapper<Book>()
            { Data = actualBook, IsSuccessful = true, Errors = [] });

        BookService bs = new BookService(_bookRepository, _tagService, _bnpLibraryService, _openLibraryService);

        ResultWrapper<Book> createdBook = await bs.CreateBook(actualBook);

        string userMessage = createdBook.Errors is { Count: > 0 } ? createdBook.Errors[0] : "";
        Assert.True(createdBook.IsSuccessful, userMessage);
    }

    [Fact]
    public async Task UpdateBook()
    {
        Book actualBook = Books.GetUpdatedBooks()[0];

        _bookRepository.UpdateBook(actualBook).Returns(new ResultWrapper<Book>()
            { Data = actualBook, IsSuccessful = true, Errors = [] });

        _bookRepository.GetBook(actualBook.Isbn).Returns(new ResultWrapper<Book>()
            { Data = actualBook, IsSuccessful = true, Errors = [] });

        BookService bs = new BookService(_bookRepository, _tagService, _bnpLibraryService, _openLibraryService);

        ResultWrapper<Book> updatedBook = await bs.UpdateBook(actualBook);

        string userMessage = updatedBook.Errors is { Count: > 0 } ? updatedBook.Errors[0] : "";
        Assert.True(updatedBook.IsSuccessful, userMessage);
    }

    [Fact]
    public async Task DeleteBook()
    {
        Book actualBook = Books.GetBooks()[0];

        _bookRepository.GetBook(actualBook.Isbn).Returns(new ResultWrapper<Book>()
            { Data = actualBook, Errors = [], IsSuccessful = true });
        _bookRepository.DeleteBook(actualBook).Returns(new ResultWrapper<Book>()
            { Data = null, Errors = [], IsSuccessful = true });
        BookService bs = new BookService(_bookRepository, _tagService, _bnpLibraryService, _openLibraryService);

        ResultWrapper<Book> deletedBook = await bs.DeleteBook(actualBook.Isbn);
        string userMessage = deletedBook.Errors is { Count: > 0 } ? deletedBook.Errors[0] : "";
        Assert.True(deletedBook.IsSuccessful, userMessage);
    }

    // [Fact]
    // public async Task GetOpenLibraryBook()
    // {
    //     BookService bs = new BookService(_bookRepository, _tagService, _bnpLibraryService, _openLibraryService);
    //
    //     ResultWrapper<Book> olBook = await bs.GetLibraryBook("9789720046673", ApiService.OpenLibrary);
    //
    //     Assert.True(olBook.IsSuccessful);
    // }
    //
    // [Fact]
    // public async Task GetBnpBook()
    // {
    //     BookService bs = new BookService(_bookRepository, _tagService, _bnpLibraryService, _openLibraryService);
    //
    //     ResultWrapper<Book> bnpBook = await bs.GetLibraryBook("9789720046673", ApiService.BibliotecaNacionalPortuguesa);
    //
    //     Assert.True(bnpBook.IsSuccessful);
    // }
}