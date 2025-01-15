using AbertaScanner.Models;

namespace AbertaScanner.Contracts.Services.Libraries;

public interface IOpenLibraryService {
    public Task<Book> GetBook(string isbn);
}