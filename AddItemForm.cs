using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Shopping_Mart_Application
{
    public partial class AddItemForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        public AddItemForm()
        {
            SQLitePCL.Batteries.Init();
            InitializeComponent();
            textBoxName.KeyDown += InputField_KeyDown;
            textBoxPrice.KeyDown += InputField_KeyDown;
            textBoxDiscount.KeyDown += InputField_KeyDown;
        }
        private void InputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound on Enter
                this.SelectNextControl((Control)sender, true, true, true, true);

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
        private void Clear_Data()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxDiscount.Text = "";
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!PassValidation())
            {
                return; // Exit if validation fails
            }
            string sql = @"INSERT INTO items_tbl (item_name,item_price,item_discount)VALUES (@item_name, @item_price, @item_discount)";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@item_name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@item_price", textBoxPrice.Text);
                    cmd.Parameters.AddWithValue("@item_discount", textBoxDiscount.Text);

                    // Open connection and execute command
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                    // Check if the registration was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    else
                    {
                        // Handle unexpected failure
                        MessageBox.Show("Item insertion is failed. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show($"SQLite error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"An invalid operation occurred: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Log or handle unexpected exceptions
                // LogError(ex); // Uncomment and implement logging if needed

                MessageBox.Show("An unexpected error occurred. Please try again later.", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clear input fields after processing
                Clear_Data();
                textBoxName.Focus();
            }
        }

        private void AddItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoyalMartForm r = new RoyalMartForm();
            r.Show();
        }
    }
}
