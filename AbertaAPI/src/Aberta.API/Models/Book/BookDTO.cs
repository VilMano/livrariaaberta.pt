namespace AbertaApi.Models;

public class BookDTO
{
    public string? Isbn { get; set; }
    public string? Title { get; set; }
    public int Stock { get; set; }
    public string? Publisher { get; set; }
    public string? CoverPicture { get; set; }
    public string? Synopsis { get; set; }
    public float Price { get; set; }
    public string? Author { get; set; }
    public string? Language { get; set; }
    public string? ReleaseDate { get; set; }
    public string? Tags { get; set; }
}