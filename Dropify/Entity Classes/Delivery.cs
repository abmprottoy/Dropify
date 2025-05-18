using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dropify
{
    public class Delivery
    {
        public Guid DeliveryID { get; set; }
        public string DeliveryType { get; set; }
        public string PackageDimension { get; set; }
        public decimal PackageWeightKg { get; set; }
        public string PackageContent { get; set; }
        public Guid Sender { get; set; }
        public string Receiver { get; set; }
        public string ReceiverName { get; set; }
        public Address PickupAddress { get; set; } 
        public Address DestinationAddress { get; set; } 
        public Transaction TransactionID { get; set; }
        public string DeliveryPersonID { get; set; }
        public string DeliveryStatus { get; set; }
        public string ExpectedDelivery { get; set; }
        public DateTimeOffset DaliveryCompletedOn { get; set; }
        public Image DeliveryProof { get; set; }
        public string DeliveryNote { get; set; }



        private string connectionString = Properties.Settings.Default.ConnectionString;
        private static string staticConnectionString = Properties.Settings.Default.ConnectionString;


        public bool PlaceDeliveryOrder(Delivery delivery)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string transactionQuery = "INSERT INTO TransactionInfo (TransactionID, PaymentMethod,Amount,Currency,TransactionTime) VALUES (@TransactionID, @PaymentMethod, @Amount, @Currency, @TransactionTime)";
                    string pickupAddressQuery = "INSERT INTO Address (AddressID, Country, City, Area, ZIP, Landmark, Office, Type) VALUES (@AddressID, @Country, @City, @Area, @ZIP, @Landmark, @Office, @Type)";
                    string destinationAddressQuery = "INSERT INTO Address (AddressID, Country, City, Area, ZIP, Landmark, Office, Type) VALUES (@AddressID, @Country, @City, @Area, @ZIP, @Landmark, @Office, @Type)";
                    string deliveryQuery = "INSERT INTO DeliveryInfo (DeliveryID,DeliveryType,PackageDimension,PackageWeightKG,PackageContent,Sender,Receiver,ReceiverName,PickupAddress,DestinationAddress,TransactionID,DeliveryStatus,ExpectedDelivery,DeliveryNote)" +
                        " VALUES (@DeliveryID,@DeliveryType,@PackageDimension,@PackageWeightKG,@PackageContent,@Sender,@Receiver,@ReceiverName,@PickupAddress,@DestinationAddress,@TransactionID,@DeliveryStatus,@ExpectedDelivery,@DeliveryNote)";

                    

                    using (SqlCommand transactionCommand = new SqlCommand(transactionQuery, connection, transaction))
                    {
                        transactionCommand.Parameters.AddWithValue("@TransactionID", delivery.TransactionID.TransactionID);
                        transactionCommand.Parameters.AddWithValue("@PaymentMethod",delivery.TransactionID.PaymentMethod);
                        transactionCommand.Parameters.AddWithValue("@Amount", delivery.TransactionID.Amount); 
                        transactionCommand.Parameters.AddWithValue("@Currency", delivery.TransactionID.Currency); 
                        transactionCommand.Parameters.AddWithValue("@TransactionTime", DateTimeOffset.UtcNow);

                        transactionCommand.ExecuteNonQuery();
                    }

                     
                    using (SqlCommand pickupAddressCommand = new SqlCommand(pickupAddressQuery, connection, transaction))
                    {
                        pickupAddressCommand.Parameters.AddWithValue("@AddressID", delivery.PickupAddress.AddressID);
                        pickupAddressCommand.Parameters.AddWithValue("@Country", delivery.PickupAddress.Country ?? (object)DBNull.Value);
                        pickupAddressCommand.Parameters.AddWithValue("@City", delivery.PickupAddress.City ?? (object)DBNull.Value);
                        pickupAddressCommand.Parameters.AddWithValue("@Area", delivery.PickupAddress.Area ?? (object)DBNull.Value);
                        pickupAddressCommand.Parameters.AddWithValue("@ZIP", delivery.PickupAddress.Zip ?? (object)DBNull.Value);
                        pickupAddressCommand.Parameters.AddWithValue("@Landmark", delivery.PickupAddress.Landmark ?? (object)DBNull.Value);
                        pickupAddressCommand.Parameters.AddWithValue("@Office", delivery.PickupAddress.Office ?? (object)DBNull.Value);
                        pickupAddressCommand.Parameters.AddWithValue("@Type", delivery.DeliveryType + " Pickup");

                        pickupAddressCommand.ExecuteNonQuery();
                    }

                    
                    using (SqlCommand destinationAddressCommand = new SqlCommand(destinationAddressQuery, connection, transaction))
                    {
                        destinationAddressCommand.Parameters.AddWithValue("@AddressID", delivery.DestinationAddress.AddressID);
                        destinationAddressCommand.Parameters.AddWithValue("@Country", delivery.DestinationAddress.Country ?? (object)DBNull.Value);
                        destinationAddressCommand.Parameters.AddWithValue("@City", delivery.DestinationAddress.City ?? (object)DBNull.Value);
                        destinationAddressCommand.Parameters.AddWithValue("@Area", delivery.DestinationAddress.Area ?? (object)DBNull.Value);
                        destinationAddressCommand.Parameters.AddWithValue("@ZIP", delivery.DestinationAddress.Zip ?? (object)DBNull.Value);
                        destinationAddressCommand.Parameters.AddWithValue("@Landmark", delivery.DestinationAddress.Landmark ?? (object)DBNull.Value);
                        destinationAddressCommand.Parameters.AddWithValue("@Office", delivery.DestinationAddress.Office ?? (object)DBNull.Value);
                        destinationAddressCommand.Parameters.AddWithValue("@Type", delivery.DeliveryType + " Destination");

                        destinationAddressCommand.ExecuteNonQuery();
                    }



                    using (SqlCommand command = new SqlCommand(deliveryQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@DeliveryID", delivery.DeliveryID);
                        command.Parameters.AddWithValue("@DeliveryType", delivery.DeliveryType);
                        command.Parameters.AddWithValue("@PackageDimension", delivery.PackageDimension);
                        command.Parameters.AddWithValue("@PackageWeightKG", delivery.PackageWeightKg);
                        command.Parameters.AddWithValue("@PackageContent", delivery.PackageContent);
                        command.Parameters.AddWithValue("@Sender", delivery.Sender);
                        command.Parameters.AddWithValue("@Receiver", delivery.Receiver);
                        command.Parameters.AddWithValue("@ReceiverName", delivery.ReceiverName);
                        command.Parameters.AddWithValue("@PickupAddress", delivery.PickupAddress.AddressID);
                        command.Parameters.AddWithValue("@DestinationAddress", delivery.DestinationAddress.AddressID);
                        command.Parameters.AddWithValue("@TransactionID", delivery.TransactionID.TransactionID);
                        command.Parameters.AddWithValue("@DeliveryStatus", delivery.DeliveryStatus);
                        command.Parameters.AddWithValue("@ExpectedDelivery", delivery.ExpectedDelivery);
                        command.Parameters.AddWithValue("@DeliveryNote", delivery.DeliveryNote);

                        command.ExecuteNonQuery();
                    }

                    // If everything is successful, commit the transaction
                    transaction.Commit();

                    MessageBox.Show("Delivery order placed succesfully.");

                    return true;

                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show("Failed to place delivery order: " + ex.Message);
                    return false;
                }
            }
            
        }

        public DataTable GetDeliveryHistory(Guid profileID)
        {
            string historyQuery = "SELECT DeliveryID, DeliveryType, PackageDimension, PackageWeightKG, PackageContent, ReceiverName, Receiver FROM DeliveryInfo WHERE Sender = @Sender";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable table = new DataTable();
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(historyQuery, connection))
                    {

                        command.Parameters.AddWithValue("@Sender", profileID);

                        SqlDataAdapter fetchdata = new SqlDataAdapter(command);
                        fetchdata.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return table;
            }
        }

        public string GetDeliveryStatus(Guid deliveryId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "SELECT DeliveryStatus FROM DeliveryInfo WHERE DeliveryID = @DeliveryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DeliveryID", deliveryId);

                        object result = command.ExecuteScalar();


                        if (result != null)
                        {

                            return result.ToString();
                        }
                        else
                        {

                            return "Delivery ID was not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error retrieving delivery status: {ex.Message}");
                return "Error retrieving status";
            }
        }


    }
}
