namespace AbertaApi.Models;

public class Tag
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool IsActive { get; set; } = true;

    public List<Book> Books { get; set; } = [];
}