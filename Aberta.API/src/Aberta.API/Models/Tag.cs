namespace AbertaApi.Models;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;

    private List<Book>? Books { get; set; } = [];
}