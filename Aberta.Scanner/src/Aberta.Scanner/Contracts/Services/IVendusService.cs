using AbertaScanner.Models;

namespace AbertaScanner.Contracts.Services;

public interface IVendusService {
    // public Task<ResultWrapper<Product>> GetEntireBookStock(int recordsPerPage);
    public Task<ResultWrapper<List<Book>>> GetBatchOfBookStock(int bookCount, int page);
    public Task<ResultWrapper<Book>> CreateBook(Book book);
}