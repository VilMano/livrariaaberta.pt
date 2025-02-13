
using Newtonsoft.Json;

namespace AbertaApi.Models;

public class Product {
    public required string Reference { get; set; }
    public required string Title { get; set; }
    public required string? Description { get; set; }

    [JsonProperty("gross_price")]
    public required string GrossPrice { get; set; }
    public required string Stock { get; set; }
    
    [JsonProperty("brand_id")]
    public required string Brand { get; set; }
    
}