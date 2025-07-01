using Aberta.Scanner.Models;

namespace Aberta.Scanner.Contracts.Services.Libraries;

public interface IOpenLibraryService {
    public Task<Book> GetBook(string isbn);
}