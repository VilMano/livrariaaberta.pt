namespace AbertaApi.Models;

public class BookSearch
{
    public required string SearchTerm { get; set; }
    public required string SortBy { get; set; }
    public required string SortOrder { get; set; }
    
    public required int Page { get; set; }
    public required int NumberOfResults { get; set; }
    public List<string>? Tags { get; set; }
    
}