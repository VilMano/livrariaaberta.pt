using Aberta.API.Utils;
using AbertaApi;
using AbertaApi.Models;
using Newtonsoft.Json;

namespace Aberta.Tests;

public class UtilsTest
{
    [Fact]
    public void ConvertStringToJsonObject()
    {
        string productsStr = VendusProducts.Products;
        List<Product>? products = JsonConvert.DeserializeObject<List<Product>?>(productsStr);

        if (products != null && products.Count > 0)
        {
            Assert.Equal(20, products.Count);
        }
        else
        {
            Assert.Fail("Something went worng.");
        }
    }

    [Fact]
    public void JoinTwoObjects()
    {
        Book book1 = new Book
        {
            Id = "978-972-0-04667-3",
            Isbn = "978-972-0-04667-3",
            Title = "",
            Stock = 12,
            Publisher = "Porto Editora",
            CoverPicture = null,
            Synopsis = null,
            Price = 0,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014-01-01",
            IsActive = true
        };

        Book book2 = new Book
        {
            Id = "978-972-0-04667-3",
            Isbn = "978-972-0-04667-3",
            Title = "As intermitências da morte",
            Stock = 0,
            Publisher = "Porto Editora",
            CoverPicture = "/pictures/books/1232.png",
            Synopsis = null,
            Price = 15,
            Author = "José Saramago",
            Language = "Português",
            ReleaseDate = "2014-01-01",
            IsActive = true
        };

        Book book = Utils.JoinObjects<Book>(book1, book2);

        Assert.True(book.CoverPicture == book2.CoverPicture);
        Assert.True(book.Title == book2.Title);
        Assert.True(book.Price == book2.Price);
        Assert.True(book.Stock == book1.Stock);
        Assert.True(book.Synopsis == null);
    }
}
