using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using Microsoft.Data.Sqlite;
namespace Shopping_Mart_Application
{
    public partial class EditItemForm : Form
    {
        private readonly string connectionString;
        public EditItemForm()
        {
            InitializeComponent();
            SQLitePCL.Batteries.Init();
            connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            BindGridView();
            textBoxName.KeyDown += InputField_KeyDown;
            textBoxPrice.KeyDown += InputField_KeyDown;
            textBoxDiscount.KeyDown += InputField_KeyDown;


        }
        private void BindGridView()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to select all items
                string sql = "SELECT * FROM items_Tbl";

                using (var command = new SqliteCommand(sql, connection))
                {
                    // Execute the command and get the reader
                    using (var reader = command.ExecuteReader())
                    {
                        // Create a DataTable to hold the results
                        DataTable dt = new DataTable();
                        dt.Load(reader); // Load method to fill the DataTable directly from the reader
                        dataGridView.DataSource = dt; // Set the DataTable as the data source
                    }
                }
            }
        }
        private bool PassValidation()
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return false;
            }

            // Validate Price
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Price cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrice.Focus();
                return false;
            }
            // Validate Discount
            if (string.IsNullOrWhiteSpace(textBoxDiscount.Text))
            {
                textBoxDiscount.Text = "0";
            }
            return true;

        }
        private void InputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound on Enter
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }
        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Check if a row is selected before accessing it
            if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxId.Text = dataGridView.SelectedRows[0].Cells["item_id"].Value.ToString();
                textBoxName.Text = dataGridView.SelectedRows[0].Cells["item_name"].Value.ToString();
                textBoxPrice.Text = dataGridView.SelectedRows[0].Cells["item_price"].Value.ToString();
                textBoxDiscount.Text = dataGridView.SelectedRows[0].Cells["item_discount"].Value.ToString();
            }
        }
        private void ClearControls()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxDiscount.Text = "";
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!PassValidation())
            {
                return; // Exit if validation fails
            }
            // Validate inputs before updating
            if (string.IsNullOrWhiteSpace(textBoxId.Text) || string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to update an item
                string sql = "UPDATE items_Tbl SET item_name = @item_name, item_price = @item_price, item_discount = @item_discount WHERE item_id = @item_id";

                using (var command = new SqliteCommand(sql, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@item_name", textBoxName.Text);
                    command.Parameters.AddWithValue("@item_price", Int32.Parse(textBoxPrice.Text)); // Parse price as decimal
                    command.Parameters.AddWithValue("@item_discount", Int32.Parse(textBoxDiscount.Text)); // Parse discount as decimal
                    command.Parameters.AddWithValue("@item_id", textBoxId.Text); // Ensure the item ID is set

                    // Execute the update command
                    command.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxName.Focus();
            ClearControls();
            BindGridView(); // Refresh the grid view after update
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!PassValidation())
            {
                return; // Exit if validation fails
            }

            // Check if an item ID is provided
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to delete an item
                string sql = "DELETE FROM items_Tbl WHERE item_id = @item_id";

                using (var command = new SqliteCommand(sql, connection))
                {
                    // Add parameter to the command
                    command.Parameters.AddWithValue("@item_id", textBoxId.Text);

                    // Execute the delete command
                    command.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxName.Focus();
            ClearControls();
            BindGridView(); // Refresh the grid view after deletion
        }

        private void EditItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoyalMartForm r = new RoyalMartForm();
            r.Show();
        }
    }
}
