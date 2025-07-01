using AbertaApi.Models;

namespace AbertaApi.Contracts.Services.Libraries;

public interface IOpenLibraryService {
    public Task<ResultWrapper<Book>> GetBook(string isbn);
}