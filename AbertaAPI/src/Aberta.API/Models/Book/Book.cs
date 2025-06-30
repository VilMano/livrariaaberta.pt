using System.Xml;
using Newtonsoft.Json;

namespace AbertaApi.Models;

public class Book
{
    public string? Id { get; set; } // aberta
    public string? Isbn { get; set; } // aberta
    public required string? Title { get; set; }
    public required int Stock { get; set; } // aberta
    public string? Publisher { get; set; }
    public string? CoverPicture { get; set; } // aberta
    public string? Synopsis { get; set; } // aberta
    public required float Price { get; set; } // aberta
    public string? Translator { get; set; }
    public string? Author { get; set; }
    public string? Language { get; set; }
    public string? ReleaseDate { get; set; }
    public required bool IsActive { get; set; } = true;
    
    public List<Tag> TagsList { get; set; } = [];
   
    public static Book ProductToBook(Product product)
    {
        var bookFromProduct = new Book
        {
            Id = product.Reference,
            Isbn = product.Reference ?? "",
            Price = float.Parse(product.GrossPrice),
            Stock = int.Parse(product.Stock),
            Title = product.Title,
            Author = product.Description,
            Publisher = product.Brand,
            IsActive = true
        };

        return bookFromProduct;
    }
}

public class BookResults
{
    public required List<Book> Results { get; set; }
    public int AmountOfResults { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}
