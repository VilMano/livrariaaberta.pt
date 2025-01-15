using AbertaApi.Models;

namespace AbertaApi.Contracts.Services;

public interface IBookService {

    public Task<ResultWrapper<BookResults>> SearchBooksByTitleAndOtherAttributes(string attributes, int numberOfRecords, int page);
    public ResultWrapper<Book> GetBook(string isbn);
    public ResultWrapper<BookResults> GetBooks(int numberOfRecords, int page, string orderQuery = "desc,alpha");
    public Task<ResultWrapper<Book>> CreateBook(Book book);
    public Task<ResultWrapper<Book>> DeleteBook(string isbn);
    public Task<ResultWrapper<Book>> UpdateBook(Book book);

    public Task<ResultWrapper<Book>> GetLibrarBook(string isbn, ApiService api);
}