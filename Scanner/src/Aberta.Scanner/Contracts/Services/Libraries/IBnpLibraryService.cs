using Aberta.Scanner.Models;

namespace Aberta.Scanner.Contracts.Services.Libraries;

public interface IBnpLibraryService {
    public Task<Book> GetBook(string isbn);
}