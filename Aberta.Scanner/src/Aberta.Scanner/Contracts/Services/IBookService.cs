using AbertaScanner.Models;

namespace AbertaScanner.Contracts.Services;

public interface IBookService {

    // public Task<ResultWrapper<Book>> GetCompleteBooks(List<Product> booksStock);
    // public Task<ResultWrapper<Book>> GetBookFromLibraries(string isbn);

    public Task VendusProcessing();

    public Task UpdateWithLibraries();
}