namespace AbertaApi.Models;

public class BookSearch
{
    public string SearchTerm { get; set; }
    public string SortBy { get; set; }
    public string SortOrder { get; set; }
    
    public int Page { get; set; }
    public int NumberOfResults { get; set; }
    
}