using System;
using System.Data.SqlClient;

namespace Dropify
{
    public class CostProvider
    {
        public static string connectionString = Properties.Settings.Default.ConnectionString;

        public static decimal GetBaseCost(string pickupCity, string destinationCity)
        {
            decimal baseCost = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT BaseCost FROM CostLookup WHERE PickupCity = @pickupCity AND DestinationCity = @destinationCity";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pickupCity", pickupCity);
                        command.Parameters.AddWithValue("@destinationCity", destinationCity);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            baseCost = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving base cost: {ex.Message}");
            }

            return baseCost;
        }

        public static decimal GetTotalCost(decimal baseCost, decimal weight)
        {
            decimal totalCost = baseCost * weight;
            return totalCost;
        }

        public static decimal GetLocalCurrencyCost(decimal costInUSD, string currency)
        {
            decimal exchangeRate = GetExchangeRate(currency);

            if (exchangeRate == 0)
            {
                return costInUSD;
            }

            decimal localCost = costInUSD * exchangeRate;
            return localCost;
        }

        private static decimal GetExchangeRate(string currency)
        {

            switch (currency)
            {
                case "AUD":
                    return 1.47m;
                case "BDT":
                    return 109.73m;
                case "CAD":
                    return 1.33m;
                case "EUR":
                    return 0.91m;
                case "USD":
                    return 1.0m;
                default:
                    return 0;
            }
        }
    }
}
