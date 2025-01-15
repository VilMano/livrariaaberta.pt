using Newtonsoft.Json;

namespace AbertaScanner.Models;

class OlObject {
    [JsonProperty("publish_date")]
    public string? PublishDate { get; set; }

    [JsonProperty("publish_country")]
    public string? PublishCountry { get; set; }

    [JsonProperty("languages")]
    public Language[]? Languages { get; set; }

    [JsonProperty("authors")]
    public Author[]? Authors {get; set;}

    [JsonProperty("oclc_numbers")]
    public string[]? OclcNumbers {get; set;}

    [JsonProperty("edition_name")]
    public string? EditionName { get; set;}

    [JsonProperty("subjects")]
    public string[]? Subjects { get; set;}

    public string? Title { get; set;}

    [JsonProperty("by_statement")]
    public string? ByStatement { get; set;}

    [JsonProperty("publishers")]
    public string[]? Publishers { get; set;}

    [JsonProperty("publish_places")]
    public string[]? PublishPlaces { get; set;}

    [JsonProperty("isbn_13")]
    public string[]? Isbn13 { get; set;}

    [JsonProperty("isbn_10")]
    public string[]? Isbn10 { get; set;}

    [JsonProperty("number_of_pages")]
    public int NumberOfPages { get; set;}

    [JsonProperty("full_title")]
    public string? FullTitle { get; set;}

    public string? Key { get; set;}

    [JsonProperty("covers")]
    public string[]? Covers {get; set;}
    
}

class Language {
    public string? Key { get; set; }
}

class Author {
    public string? Key { get; set; }
}