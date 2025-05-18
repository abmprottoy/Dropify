using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    public class TimeZoneInfoProvider
    {
        private static readonly Dictionary<string, List<string>> TimeZonesCities = new Dictionary<string, List<string>>()
    {
        {"AUS Eastern Standard Time", new List<string> {"Sydney", "Melbourne"}},
        {"E. Australia Standard Time", new List<string> {"Brisbane"}},
        {"W. Australia Standard Time", new List<string> {"Perth"}},
        {"Cen. Australia Standard Time", new List<string> {"Adelaide"}},
        {"Central Asia Standard Time", new List<string> {"Dhaka", "Chittagong", "Khulna", "Barisal", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet"}},
        {"Eastern Standard Time", new List<string> {"Toronto", "Montreal", "Ottawa", "New York City", "Miami"}},
        {"Pacific Standard Time", new List<string> {"Vancouver", "Los Angeles"}},
        {"Mountain Standard Time", new List<string> {"Calgary"}},
        {"Central European Standard Time", new List<string> {"Berlin", "Munich", "Hamburg", "Frankfurt", "Cologne"}},
        {"Central Standard Time", new List<string> {"Chicago", "Houston"}}
    };

        public static string GetTimeZone(string cityName)
        {
            foreach (var kvp in TimeZonesCities)
            {
                if (kvp.Value.Contains(cityName, StringComparer.OrdinalIgnoreCase))
                {
                    return kvp.Key;
                }
            }

            return String.Empty;
        }


        public static DateTime GetCityTime(string cityName)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
             
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(GetTimeZone(cityName));
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            
            return dateTime;
        } 


    }
}
