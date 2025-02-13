namespace AbertaBackOffice.Models;

public class Book
{
    public string? Id { get; set; } // aberta
    public string? Isbn { get; set; } // aberta
    public string? Title { get; set; }
    public int Stock { get; set; } // aberta
    public string? Publisher { get; set; }
    public string? CoverPicture { get; set; } // aberta
    public string? Translator { get; set; }
    public string? Synopsis { get; set; } // aberta
    public float Price { get; set; } // aberta
    public string? Author { get; set; }
    public string? Language { get; set; }
    public string? ReleaseDate { get; set; }
    public bool IsActive { get; set; } = true;
    
    public List<Tag>? TagsList { get; set; } = [];
}

public class BookDto
{
    public List<Book> Results { get; set; } = new List<Book>();
    public int AmountOfResults { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}