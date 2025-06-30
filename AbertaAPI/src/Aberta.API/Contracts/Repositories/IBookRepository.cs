using AbertaApi.Models;

namespace AbertaApi.Contracts.Repositories;

public interface IBookRepository{
    public Task<ResultWrapper<Book>> CreateBook(Book book);
    public ResultWrapper<Book> GetBook(string isbn);
    public ResultWrapper<List<Book>> GetBooks(bool isActive);
    public Task<ResultWrapper<Book>> UpdateBook(Book book);
    public Task<ResultWrapper<Book>> DeleteBook(Book book);

}