using System.Net.Http.Headers;
using Serilog;

namespace AbertaApi;

public static class Utils
{
    public static async Task<HttpResponseMessage> GetAsync(HttpClient clientRequest, string uri)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = clientRequest.BaseAddress;

            foreach (var requestHeader in clientRequest.DefaultRequestHeaders.Accept)
                client.DefaultRequestHeaders.Accept.Add(requestHeader);
            
            try
            {
                return await client.GetAsync(uri);
            }
            catch (System.Exception e)
            {
                Log.Error(e, ".net error");
                throw;
            }
        }
    }

    public static bool StringContains(string text, string pattern)
    {
        string normalisedText = text.ToLowerInvariant();
        string normalizedPattern = pattern.ToLowerInvariant();

        int indexOfPattern = normalisedText.IndexOf(normalizedPattern);
        
        if (normalisedText.IndexOf(normalizedPattern) != -1)
            return true;

        return false;
    }

    public static string CleanIsbn(string isbn)
    {
        // I will probably just use regex for this
        return isbn.Trim().Replace("-", "").Replace(" ", "");
    }

    public static T? JoinObjects<T>(T obj1, T obj2)
    {
        if (obj1 != null && obj2 != null)
        {
            var obj1Props = obj1.GetType().GetProperties();

            foreach (var prop in obj1Props)
            {
                if (prop.GetValue(obj1) == null || 
                    (prop.GetValue(obj1) != null && (prop.GetValue(obj1).ToString() == "" || prop.GetValue(obj1).ToString() == "0")))
                {
                    object valueObj2 = prop.GetValue(obj2);

                    if (valueObj2 != null)
                        prop.SetValue(obj1, valueObj2);
                }
            }

            return obj1;
        }

        if(obj2 != null){
            obj1 = obj2;
        }

        return obj1;
    }
}
