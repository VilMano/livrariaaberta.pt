namespace AbertaScanner.Models;

public class ResultWrapper<T>
{
    public bool IsSuccessful { get; set; }
    public T Data { get; set; }
    public List<string> Errors { get; set; } = [];
}