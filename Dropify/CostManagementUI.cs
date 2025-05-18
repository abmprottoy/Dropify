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
    public partial class CostManagementUI : UserControl
    {

        private string connectionString = Properties.Settings.Default.ConnectionString;
        private DataGridViewRow selectedRow;

        public CostManagementUI()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeDataGridViewColumnCustomization();
        }


        private void InitializeDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PickupCity, DestinationCity, BaseCost FROM CostLookup";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Make the DataGridView read-only
                            dataGridView1.ReadOnly = true;

                            // Bind data to the DataGridView
                            dataGridView1.DataSource = dataTable;

                            dataGridView1.EnableHeadersVisualStyles = false;
                            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                            dataGridView1.ColumnHeadersHeight = 27;
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InitializeDataGridViewColumnCustomization()
        {


            // Set the column header style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateEditors(e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateEditors(e);
        }

        private void UpdateEditors(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Store the selected row for later use
                selectedRow = dataGridView1.Rows[e.RowIndex];

                // Display values in textboxes for editing
                tbxPickup.Text = selectedRow.Cells["PickupCity"].Value.ToString();
                tbxDestination.Text = selectedRow.Cells["DestinationCity"].Value.ToString();
                tbxBaseCost.Text = selectedRow.Cells["BaseCost"].Value.ToString();
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // Validate and update the selected row with the values from textboxes
                if (ValidateInput())
                {
                    UpdateRecord(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateInput()
        {
            // Validate the input in the TextBox for BaseCost
            if (double.TryParse(tbxBaseCost.Text, out double baseCost))
            {
                // Validation successful
                return true;
            }
            else
            {
                // Validation failed
                MessageBox.Show("Invalid BaseCost value.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void UpdateRecord(DataGridViewRow row)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE CostLookup 
                     SET PickupCity = @PickupCity, DestinationCity = @DestinationCity, BaseCost = @BaseCost 
                     WHERE PickupCity = @PickupCity AND DestinationCity = @DestinationCity";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@PickupCity", row.Cells["PickupCity"].Value);
                        command.Parameters.AddWithValue("@DestinationCity", row.Cells["DestinationCity"].Value);

                        // Use the validated baseCost value
                        if (double.TryParse(tbxBaseCost.Text, out double baseCost))
                        {
                            command.Parameters.AddWithValue("@BaseCost", baseCost);
                        }
                        else
                        {
                            // Handle the case where validation fails (shouldn't reach here due to ValidateInput)
                            MessageBox.Show("Invalid BaseCost value.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Do not proceed with the update
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InitializeDataGridView();
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



    }
}
