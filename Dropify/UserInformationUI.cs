using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class UserInformationUI : UserControl
    {
        private string connectionString = Properties.Settings.Default.ConnectionString;
        public UserInformationUI()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            InitializeDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT ProfileID, ProfileImage, FirstName, LastName, DOB, Gender, Country, GovtIDType, GovtID, AddressID FROM PersonalInfo WHERE ProfileID <> '570aec5c-f3db-42d3-8cae-09323bb45edb'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                            // Optionally, set the image column to display images
                            dataGridView1.Columns["ProfileImage"].DefaultCellStyle.NullValue = null;
                            dataGridView1.Columns["ProfileImage"].DefaultCellStyle.Padding = new Padding(5);
                            dataGridView1.RowTemplate.Height = 90;

                            // Add buttons for Update and Delete
                            AddButtonColumn("Update", "Update", "Update", 60);
                            AddButtonColumn("Delete", "Delete", "Delete", 60);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridView()
        {
            // Optionally, customize DataGridView appearance or behavior here
        }

        private void AddButtonColumn(string columnName, string headerText, string buttonText, int width)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = columnName;
            buttonColumn.HeaderText = headerText;
            buttonColumn.Text = buttonText;
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.Width = width;
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle button clicks for Update and Delete
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
                {
                    // Handle Update button click
                    // Perform database update based on the row data
                    UpdateRecord(row);
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    // Handle Delete button click
                    // Perform database delete based on the row data
                    DeleteRecord(row);
                }
            }
        }


        private void UpdateRecord(DataGridViewRow row)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE PersonalInfo 
                             SET FirstName = @FirstName, LastName = @LastName, 
                                 DOB = @DOB, Gender = @Gender, 
                                 Country = @Country, GovtIDType = @GovtIDType, GovtID = @GovtID 
                             WHERE ProfileID = @ProfileID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@ProfileID", (Guid)row.Cells["ProfileID"].Value);
                        command.Parameters.AddWithValue("@FirstName", row.Cells["FirstName"].Value);
                        command.Parameters.AddWithValue("@LastName", row.Cells["LastName"].Value);
                        command.Parameters.AddWithValue("@DOB", row.Cells["DOB"].Value);
                        command.Parameters.AddWithValue("@Gender", row.Cells["Gender"].Value);
                        command.Parameters.AddWithValue("@Country", row.Cells["Country"].Value);
                        command.Parameters.AddWithValue("@GovtIDType", row.Cells["GovtIDType"].Value);
                        command.Parameters.AddWithValue("@GovtID", row.Cells["GovtID"].Value);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.Columns.Clear();
                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Record update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecord(DataGridViewRow row)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                User userToBeDeleted = new User();
                userToBeDeleted.GetUserInfo(userToBeDeleted, (Guid)row.Cells["ProfileID"].Value);

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string deleteLoginQuery = "DELETE FROM Login WHERE ProfileID = @ProfileID";
                        using (SqlCommand command = new SqlCommand(deleteLoginQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ProfileID", userToBeDeleted.ProfileID);
                            int loginRowsAffected = command.ExecuteNonQuery();

                            if (loginRowsAffected > 0)
                            {
                                string deleteAddressQuery = "DELETE FROM Address WHERE AddressID = @AddressID";
                                using (SqlCommand addressCommand = new SqlCommand(deleteAddressQuery, connection, transaction))
                                {
                                    addressCommand.Parameters.AddWithValue("@AddressID", userToBeDeleted.address.AddressID);
                                    int addressRowsAffected = addressCommand.ExecuteNonQuery();

                                    if (addressRowsAffected > 0)
                                    {
                                        transaction.Commit();
                                        MessageBox.Show("Successfully deleted.");
                                        dataGridView1.Columns.Clear();
                                        LoadDataIntoDataGridView();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while Deleting", ex.Message);
                        transaction.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the edited row
                DataGridViewRow editedRow = dataGridView1.Rows[e.RowIndex];

                // Ensure that the row is not a new row (for example, when user is adding a new row)
                if (!editedRow.IsNewRow)
                {
                    // Create a SqlConnection
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Construct the UPDATE query
                        string updateQuery = @"UPDATE PersonalInfo 
                                       SET FirstName = @FirstName, LastName = @LastName, 
                                           DOB = @DOB, Gender = @Gender, 
                                           Country = @Country, GovtIDType = @GovtIDType, GovtID = @GovtID 
                                       WHERE ProfileID = @ProfileID";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            // Set parameters
                            updateCommand.Parameters.AddWithValue("@ProfileID", (Guid)editedRow.Cells["ProfileID"].Value);
                            updateCommand.Parameters.AddWithValue("@FirstName", editedRow.Cells["FirstName"].Value);
                            updateCommand.Parameters.AddWithValue("@LastName", editedRow.Cells["LastName"].Value);
                            updateCommand.Parameters.AddWithValue("@DOB", editedRow.Cells["DOB"].Value);
                            updateCommand.Parameters.AddWithValue("@Gender", editedRow.Cells["Gender"].Value);
                            updateCommand.Parameters.AddWithValue("@Country", editedRow.Cells["Country"].Value);
                            updateCommand.Parameters.AddWithValue("@GovtIDType", editedRow.Cells["GovtIDType"].Value);
                            updateCommand.Parameters.AddWithValue("@GovtID", editedRow.Cells["GovtID"].Value);

                            // Execute the UPDATE query
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Record update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ProfileID"].Index || e.ColumnIndex == dataGridView1.Columns["AddressID"].Index || e.ColumnIndex == dataGridView1.Columns["ProfileImage"].Index)
            {
                e.Cancel = true;
                MessageBox.Show("ProfileID, ProfileImage and AddressID are not editable.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

