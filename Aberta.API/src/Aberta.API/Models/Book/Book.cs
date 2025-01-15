using System.Xml;
using AbertaApi.Services;
using Newtonsoft.Json;

namespace AbertaApi.Models;

public class Book
{
    public string? Id { get; set; } // aberta
    public string? Isbn { get; set; } // aberta
    public string? Title { get; set; }
    public int Stock { get; set; } // aberta
    public string? Publisher { get; set; }
    public string? CoverPicture { get; set; } // aberta
    public string? Synopsis { get; set; } // aberta
    public float Price { get; set; } // aberta
    public string? Author { get; set; }
    public string? Language { get; set; }
    public string? ReleaseDate { get; set; }
    public bool isActive { get; set; } = true;
    
    public List<Tag>? TagsList { get; set; } = [];
   
    public static Book ProductToBook(Product product)
    {
        Book bookFromProduct = new Book
        {
            Id = product.Reference,
            Isbn = product.Reference ?? "",
            Price = float.Parse(product.GrossPrice),
            Stock = int.Parse(product.Stock),
            Title = product.Title
        };

        return bookFromProduct;
    }
}

public class BookResults
{
    public List<Book> results { get; set; }
    public int AmmountOfResults { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}
