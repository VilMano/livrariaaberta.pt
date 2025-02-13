using System.Net.Http.Headers;
using System.Xml;
using AbertaApi;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;
using Serilog;

namespace Aberta.API.Services;

public class BnpLibraryService(IConfiguration configuration, ILogger<BnpLibraryService> logger) : IBnpLibraryService
{
    public async Task<ResultWrapper<Book>> GetBook(string isbn)
    {
        logger.LogInformation("Getting book from Bnp Library...");
        var book = new ResultWrapper<Book>();
        
        try
        {
            isbn = Utils.Utils.CleanIsbn(isbn);

            var client = new HttpClient();
            client.BaseAddress = new Uri(configuration["Bnp:BaseUrl"] ?? string.Empty);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
            var request = await client.GetAsync($"?id={isbn}");

            if (!request.IsSuccessStatusCode) return book;
            
            var bookXml = await request.Content.ReadAsStringAsync();
            book.Data = BnpLibraryXmlToBook(bookXml);
            book.IsSuccessful = true;

            return book;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            return book;
        }
    }

    private static Book BnpLibraryXmlToBook(string xml)
    {
        var doc = new XmlDocument();
        doc.LoadXml(xml);

        Book fetchedBook = new()
        {
            Title = "",
            Stock = 0,
            Price = 0,
            IsActive = false
        };

        if (xml.Contains("registo inexistente", StringComparison.CurrentCultureIgnoreCase)) return fetchedBook;
        
        var nodes = doc.ChildNodes[1]?.ChildNodes[0]?.ChildNodes;
        if (nodes == null) return fetchedBook;
        
        foreach (XmlNode node in nodes)
        {
            switch (node.LocalName)
            {
                case "language":
                    if (fetchedBook.Language == null)
                    {
                        foreach (XmlNode language in node.ChildNodes)
                        {
                            if (language.Attributes?["type"] == null) continue;

                            if (language.Attributes["type"]?.Value == "text")
                            {
                                fetchedBook.Language = language.InnerText;
                            }
                        }
                    }

                    break;
                case "originInfo":
                    foreach (XmlNode info in node.ChildNodes)
                    {
                        if (fetchedBook.ReleaseDate != null) continue;

                        if (info.LocalName == "dateIssued")
                            fetchedBook.ReleaseDate = info.InnerText;
                    }

                    break;
            }
        }

        return fetchedBook;
    }
}