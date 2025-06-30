using static System.Int32;

namespace Aberta.Scanner;

public static class Utils
{
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
                if (prop.GetValue(obj1) != null &&
                    (prop.GetValue(obj1) == null ||
                     (prop.GetValue(obj1).ToString() != "" && prop.GetValue(obj1).ToString() != "0"))) continue;
                
                var valueObj2 = prop.GetValue(obj2);

                if (valueObj2 != null)
                    prop.SetValue(obj1, valueObj2);
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
        var normalisedDateStr = "";
        
        for(var i = 0; i < date.Length - 3; i++){
            var normalisedDate = $"{date[i]}{date[i+1]}{date[i+2]}{date[i+3]}";
            normalisedDate = normalisedDate.Replace("-", "");
            TryParse(normalisedDate, out var n);
            var numberString = n.ToString();

            if (numberString.Length != 4) continue;
            
            normalisedDateStr = n.ToString();
            break;
        }

        return normalisedDateStr;
    }
}
