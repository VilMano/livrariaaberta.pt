
using AbertaApi.Models;

namespace AbertaApi.Contracts.Services;

public interface IVendusService {
    public Task<ResultWrapper<Book>> GetBook(string isbn);
    public Task<ResultWrapper<List<Book>>> GetBatchOfBookStock(int bookCount, int page);
}