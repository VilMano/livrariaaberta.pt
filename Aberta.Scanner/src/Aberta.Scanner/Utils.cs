using System.Net.Http.Headers;
using System.Text.Json.Nodes;
using System.Xml;
using AbertaScanner.Models;
using AbertaScanner.Services.Libraries;
using AbertaScanner.Models;
using Newtonsoft.Json;
using Serilog;

namespace AbertaScanner;

public static class Utils
{
    public static async Task<HttpResponseMessage> GetAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
            
            try
            {
                int a = 0;
                return await client.GetAsync("");
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

    // this goofy function will only work until the year of 9999 <:)
    public static string CaptureYearInDate(string date)
    {
        string normalisedDateStr = "";
        
        for(int i = 0; i < date.Length - 3; i++){
            string normalisedDate = $"{date[i]}{date[i+1]}{date[i+2]}{date[i+3]}";
            normalisedDate = normalisedDate.Replace("-", "");
            int n;
            var isNumber = int.TryParse(normalisedDate, out n);
            string numberString = n.ToString();
            
            if(numberString.Length == 4){
                normalisedDateStr = n.ToString();
                break;
            }
        }

        return normalisedDateStr;
    }
}
