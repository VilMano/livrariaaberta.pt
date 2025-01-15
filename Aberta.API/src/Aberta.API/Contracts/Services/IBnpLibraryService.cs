using AbertaApi.Models;

namespace AbertaApi.Contracts.Services.Libraries;

public interface IBnpLibraryService {
    public Task<ResultWrapper<Book>> GetBook(string isbn);
}