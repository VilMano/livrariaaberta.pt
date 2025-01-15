using AbertaApi.Models;

namespace AbertaApi.Contracts.Repositories;

public interface IBookRepository{
    public Task<ResultWrapper<Book>> CreateBook(Book book);
    public ResultWrapper<Book> GetBook(string isbn);
    public Task<ResultWrapper<Book>> UpdateBook(Book book);
    public Task<ResultWrapper<Book>> DeleteBook(Book book);
    public ResultWrapper<List<Book>> GetBooks(Func<Book, bool> expression, int records, int skip, bool orderDescending = false, Order orderBy = Order.Alphabetical);
}