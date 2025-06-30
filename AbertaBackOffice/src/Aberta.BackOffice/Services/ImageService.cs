using System.Net;
using System.Net.Http.Headers;
using System.Text;
using AbertaApi.Models;
using AbertaBackOffice.Models;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;

namespace AbertaBackOffice.Services;

public class ImageService(IConfiguration configuration)
{
    public async Task<bool> Exists(string path)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri($"{configuration.GetValue<string>("AbertaApi:BaseUrl")}Image/{path}");

        HttpResponseMessage request = await client.GetAsync("");

        if (request.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }

    public async Task CreateImage(string isbn, IBrowserFile file)
    {
        using (var form = new MultipartFormDataContent())
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-API-KEY", configuration.GetValue<string>("AbertaApi:ApiKey"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            Byte[] byteArr;
            using (MemoryStream ms = new MemoryStream())
            {
                await file.OpenReadStream(maxAllowedSize: file.Size).CopyToAsync(ms);
                byteArr = ms.ToArray();
            }
            
            var imageContent = new ByteArrayContent(byteArr);
            imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse(file.ContentType);

            string imageExtension = file.Name.Split('.')[1]; 
            form.Add(imageContent, "file", $"{isbn}.{imageExtension}");

            var response = await client.PostAsync(configuration.GetValue<string>("AbertaApi:ImageUrl") + "create", form);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("File created");
            }
            else
            {
                Console.WriteLine($"Failed to upload data: {response.StatusCode}");
            }
        }
    }
}