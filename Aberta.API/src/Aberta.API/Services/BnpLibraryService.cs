using System.Net.Http.Headers;
using System.Xml;
using AbertaApi;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Models;
using Serilog;

namespace AbertaScanner.Services;

public class BnpLibraryService(IConfiguration configuration) : IBnpLibraryService
{
    public async Task<ResultWrapper<Book>> GetBook(string isbn)
    {
        ResultWrapper<Book> book = new ResultWrapper<Book>();
        
        try
        {
            isbn = Utils.CleanIsbn(isbn);

            var client = new HttpClient();
            client.BaseAddress = new Uri(configuration["Bnp:BaseUrl"]);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
            HttpResponseMessage request = await Utils.GetAsync(client, $"?id={isbn}");

            if (request.IsSuccessStatusCode)
            {
                string bookXml = request.Content.ReadAsStringAsync().Result;
                book.Data = BnpLibraryXmlToBook(bookXml);
                return book;
            }
            else
            {
                return book;
            }
        }
        catch (Exception e)
        {
            Log.Error(e, ".NET error");
            return book;
        }
    }
    
    public static Book BnpLibraryXmlToBook(string xml)
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xml);

        Book fetchedBook = new();

        if (!xml.ToLower().Contains("registo inexistente"))
        {
                XmlNodeList nodes = doc.ChildNodes[1].ChildNodes[0].ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    switch (node.LocalName)
                    {
                        case "identifier":

                            if (node.Attributes["type"].Value == "uri")
                            {
                                break;
                            }

                            if (fetchedBook.Isbn == null)
                            {
                                if (node.Attributes["type"].Value == "isbn")
                                {
                                    fetchedBook.Isbn = node.InnerText;
                                    break;
                                }
                            }

                            if (node.Attributes["type"].Value == "stock")
                            {
                                break;
                            }
                            break;
                        case "titleInfo":
                            if (fetchedBook.Title == null)
                                fetchedBook.Title = node.ChildNodes[0].InnerText;

                            break;
                        case "name":
                            if (fetchedBook.Author == null)
                            {
                                // check if name tag is for creator or contributor
                                bool isCreator = false;
                                foreach (XmlNode nameTags in node.ChildNodes)
                                {
                                    if (nameTags.LocalName == "role")
                                    {
                                        foreach (XmlNode role in nameTags.ChildNodes)
                                        {
                                            if (role.LocalName == "roleTerm")
                                            {
                                                if (role.Attributes["type"] != null)
                                                    if (role.Attributes["type"].Value == "text")
                                                    {
                                                        if (role.InnerText == "creator")
                                                        {
                                                            isCreator = true;
                                                        }
                                                    }
                                            }
                                        }
                                    }
                                }

                                if (isCreator)
                                {
                                    if (node.Attributes["type"] != null)
                                    {
                                        if (node.Attributes["type"].Value == "personal")
                                        {
                                            foreach (XmlNode name in node.ChildNodes)
                                            {
                                                if (name.LocalName == "namePart")
                                                {
                                                    string nodeText = name.InnerText;
                                                    string[] nameArr = nodeText.Split(",");

                                                    fetchedBook.Author =
                                                        nameArr[1].Trim() + " " + nameArr[0].Trim();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            break;
                        case "language":
                            if (fetchedBook.Language == null)
                            {
                                foreach (XmlNode language in node.ChildNodes)
                                {
                                    if (language.Attributes["type"] != null)
                                    {
                                        if (language.Attributes["type"].Value == "text")
                                        {
                                            fetchedBook.Language = language.InnerText;
                                        }
                                    }
                                }
                            }
                            break;
                        case "originInfo":
                            foreach (XmlNode info in node.ChildNodes)
                            {
                                if (fetchedBook.Publisher == null)
                                    if (info.LocalName == "publisher")
                                        fetchedBook.Publisher = info.InnerText;

                                if (fetchedBook.ReleaseDate == null)
                                    if (info.LocalName == "dateIssued")
                                        fetchedBook.ReleaseDate = info.InnerText;
                            }
                            break;
                        default:
                            break;
                    }
                }
        }

        return fetchedBook;
    }
}