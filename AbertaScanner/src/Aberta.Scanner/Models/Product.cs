
using Newtonsoft.Json;

namespace Aberta.Scanner.Models;

public class Product {
    public string? Reference { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }

    [JsonProperty("gross_price")]
    public string? GrossPrice { get; set; }
    public string? Stock { get; set; }
}