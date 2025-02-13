using AbertaApi.Models;

namespace Aberta.Tests.Content;

public class Books
{
    public static List<Book> GetBooks() =>
    [
        new Book
        {
            Id = "9789720046673",
            Isbn = "9789720046673",
            Title = "As intermitências da morte",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "",
            Synopsis = "",
            Price = 0,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014",
            IsActive = true,
        },
        new Book
        {
            Id = "9780008637569",
            Isbn = "9780008637569",
            Title = "Day",
            Stock = 1,
            Publisher = "",
            CoverPicture = "",
            Synopsis = "",
            Price = 16,
            Author = "Michael Cunningham",
            Language = "inglês",
            ReleaseDate = "2023",
            IsActive = true
        }
    ];
    
    public static List<Book> GetUpdatedBooks() =>
    [
        new Book
        {
            Id = "9789720046673",
            Isbn = "9789720046673",
            Title = "A morte",
            Stock = 3,
            Publisher = "Porto",
            CoverPicture = "/images/9789720046673",
            Synopsis = "",
            Price = 12,
            Author = "José",
            Language = "Tuga",
            ReleaseDate = "2015-10-03",
            IsActive = true
        }
    ];
    
    public static List<Book> GetInvalidBooks() =>
    [
        new Book
        {
            Id = "9780345637511",
            Isbn = "9780345637511",
            Title = "",
            Stock = 1,
            Publisher = "",
            CoverPicture = "",
            Synopsis = "",
            Price = 16,
            Author = "Michael Cunningham",
            Language = "Espanhol",
            ReleaseDate = "2023",
            IsActive = true
        },
        new Book
        {
            Id = "",
            Isbn = "9780345631234",
            Title = "Da",
            Stock = 1,
            Publisher = "",
            CoverPicture = "",
            Synopsis = "",
            Price = 16,
            Author = "Michael Cunningham",
            Language = "Espanhol",
            ReleaseDate = "2023",
            IsActive = true
        }
    ];
}