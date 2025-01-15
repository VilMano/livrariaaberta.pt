using System.Xml;
using AbertaScanner.Services.Libraries;
using Newtonsoft.Json;

namespace AbertaScanner.Models;

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
}

public class BookDTO
{
    public List<Book> results { get; set; }
    public int AmmountOfResults { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}