using AbertaApi.Models;

namespace AbertaApi.Contracts.Services;

public interface IBookService {

    public ResultWrapper<BookResults> SearchBooks(BookSearch search, bool isActive);
    public ResultWrapper<Book> GetBook(string isbn);
    public Task<ResultWrapper<Book>> CreateBook(Book book);
    public Task<ResultWrapper<Book>> DeleteBook(string isbn);
    public Task<ResultWrapper<Book>> UpdateBook(Book book);

    public Task<ResultWrapper<Book>> GetLibraryBook(string isbn, ApiService api);
}