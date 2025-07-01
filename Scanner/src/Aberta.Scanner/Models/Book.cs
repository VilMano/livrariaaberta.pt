using System.Xml;
using Newtonsoft.Json;

namespace Aberta.Scanner.Models;

public class Book
{
    public string? Id { get; set; } // aberta
    public string? Isbn { get; set; } // aberta
    public required string? Title { get; set; }
    public required int Stock { get; set; } // aberta
    public string? Publisher { get; set; }
    public string? CoverPicture { get; init; } // aberta
    public string? Synopsis { get; set; } // aberta
    public required float Price { get; set; } // aberta
    public string? Translator { get; set; }
    public string? Author { get; set; }
    public string? Language { get; set; }
    public string? ReleaseDate { get; set; }
    public required bool IsActive { get; set; } = false;
    
    public List<Tag> TagsList { get; set; } = [];
}

public class BookResults
{
    public required List<Book> results { get; set; }
    public int AmountOfResults { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}