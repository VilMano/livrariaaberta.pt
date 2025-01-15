using System.Net.Http.Headers;

namespace AbertaScanner;

public static class HttpRequests
{
    public static async Task<HttpResponseMessage> GetAsync(HttpClient clientRequest, string uri)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = clientRequest.BaseAddress;

        foreach (var header in clientRequest.DefaultRequestHeaders)
        {
            client.DefaultRequestHeaders.Add(header.Key, header.Value);
        }
        
        foreach (var header in clientRequest.DefaultRequestHeaders.Accept)
        {
            client.DefaultRequestHeaders.Accept.Add(header);
        }
        
        client.DefaultRequestHeaders.Add("X-API-KEY", "abertapi-BDaCPiyPOwIsMbKzZ8wnERQKNrouzpPtA7bk2VUK8J1jKuRD9ULp5ZdsuIRGThKjVUEJLhp19qFcIWbyq3eKNQVAnLcNAcaBvGtQFfkLtK5fcwDLpE8yV7K");

        // List data response
        HttpResponseMessage response = client.GetAsync(uri).Result;
        client.Dispose();
        
        return response;
    }
    
    public static async Task<HttpResponseMessage> PostAsync<T>(HttpClient clientRequest, string uri, T obj)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = clientRequest.BaseAddress;
        
        foreach (var header in clientRequest.DefaultRequestHeaders)
        {
            client.DefaultRequestHeaders.Add(header.Key, header.Value);
        }
        
        foreach (var header in clientRequest.DefaultRequestHeaders.Accept)
        {
            client.DefaultRequestHeaders.Accept.Add(header);
        }
        
        client.DefaultRequestHeaders.Add("X-API-KEY", "abertapi-BDaCPiyPOwIsMbKzZ8wnERQKNrouzpPtA7bk2VUK8J1jKuRD9ULp5ZdsuIRGThKjVUEJLhp19qFcIWbyq3eKNQVAnLcNAcaBvGtQFfkLtK5fcwDLpE8yV7K");

        // List data response.
        HttpResponseMessage response = await client.PostAsJsonAsync(
            uri, obj);
        
        client.Dispose();
        
        return response;
    }
    
    public static async Task<HttpResponseMessage> DeleteAsync<T>(HttpClient clientRequest, string uri)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = clientRequest.BaseAddress;
        
        foreach (var header in clientRequest.DefaultRequestHeaders)
        {
            client.DefaultRequestHeaders.Add(header.Key, header.Value);
        }
        
        foreach (var header in clientRequest.DefaultRequestHeaders.Accept)
        {
            client.DefaultRequestHeaders.Accept.Add(header);
        }
        
        client.DefaultRequestHeaders.Add("X-API-KEY", "abertapi-BDaCPiyPOwIsMbKzZ8wnERQKNrouzpPtA7bk2VUK8J1jKuRD9ULp5ZdsuIRGThKjVUEJLhp19qFcIWbyq3eKNQVAnLcNAcaBvGtQFfkLtK5fcwDLpE8yV7K");

        HttpResponseMessage response = await client.DeleteAsync(
            uri);
        
        client.Dispose();
        
        return response;
    }
}