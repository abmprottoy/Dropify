using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    public class CurrencyProvider
    {
        public static readonly Dictionary<string, string> CountryCurrencies = new Dictionary<string, string>
        {
            {"Australia", "AUD"},
            {"Bangladesh", "BDT"},
            {"Canada", "CAD"},
            {"Germany", "EUR"},
            {"United States", "USD"}
        };

        public static string GetCurrency(string inputCountry)
        {
            foreach (var kvp in CountryCurrencies)
            {
                if (string.Equals(kvp.Key, inputCountry, StringComparison.OrdinalIgnoreCase))
                {
                    return kvp.Value;
                }
            }

            return String.Empty;
        }
    }
}
