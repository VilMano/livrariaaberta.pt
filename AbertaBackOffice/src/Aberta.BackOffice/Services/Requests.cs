using Newtonsoft.Json;

namespace AbertaBackOffice.Services;

public class Requests
{
    private readonly string _apiKey;
    
    public Requests(IConfiguration configuration)
    {
        _apiKey = configuration.GetValue<string>("AbertaApi:ApiKey");
    }

    public async Task<T> GetAsync<T>(string uri)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-API-KEY", _apiKey);
        
        client.BaseAddress = new Uri(uri);

        try
        {
            var request = await client.GetAsync("");

            if (request.IsSuccessStatusCode)
            {
                var json = await request.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<T>(json);

                return res;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return default;
    }

    public async Task<T> PostJsonAsync<T>(string uri, object body)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-API-KEY", _apiKey);
        client.BaseAddress = new Uri(uri);
        
        HttpResponseMessage request = await client.PostAsJsonAsync("", body);

        if (request.IsSuccessStatusCode)
        {
            string json = await request.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<T>(json);

            return res;
        }

        return default;
    }
}