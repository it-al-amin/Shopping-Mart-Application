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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Shopping_Mart_Application
{
    public partial class SignupForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        public SignupForm()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            // Attach KeyDown event handlers
            textBoxName.KeyDown += InputField_KeyDown;
            textBoxSurname.KeyDown += InputField_KeyDown;
            comboBox.KeyDown += InputField_KeyDown;
            numericUpDown.KeyDown += InputField_KeyDown;
            textBoxAddress.KeyDown += InputField_KeyDown;
            textBoxEamil.KeyDown += InputField_KeyDown;
            textBoxPassword.KeyDown += InputField_KeyDown;
            textBoxConfirmsPassword.KeyDown += InputField_KeyDown;
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

            // Validate Surname
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                MessageBox.Show("Surname cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSurname.Focus();
                return false;
            }

            // Validate Gender
            if (comboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox.Focus();
                return false;
            }

            // Validate Age
            if (numericUpDown.Value <= 0)
            {
                MessageBox.Show("Age must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown.Focus();
                return false;
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAddress.Focus();
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(textBoxEamil.Text) || !IsValidEmail(textBoxEamil.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEamil.Focus();
                return false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || textBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                return false;
            }
            if (textBoxConfirmsPassword.Text != textBoxPassword.Text)
            {
                MessageBox.Show("Password must be same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxConfirmsPassword.Focus();
                return false;
            }

            return true; // All validations passed
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void Clear_Data()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            comboBox.SelectedIndex = 0; // or use an appropriate default
            numericUpDown.Value = 0;
            textBoxAddress.Clear();
            textBoxEamil.Clear();
            textBoxPassword.Clear();
            textBoxConfirmsPassword.Clear();
        }
        private void SignupBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!PassValidation())
            {
                return; // Exit if validation fails
            }

            // SQL command for inserting new user
            string sql = @"
        INSERT INTO UserSignup_tbl (Name, SurName, Gender, Age, Address, Email, Password) 
        VALUES (@Name, @SurName, @Gender, @Age, @Address, @Email, @Password)";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@SurName", textBoxSurname.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox.Text);
                    cmd.Parameters.AddWithValue("@Age", (int)numericUpDown.Value);
                    cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEamil.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                    // Open connection and execute command
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                    // Check if the registration was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally handle successful login (e.g., pass user data to the next form)
                        this.Hide();
                        loginForm form = new loginForm();
                        form.ShowDialog();
                        
                    }
                    else
                    {
                        // Handle unexpected failure
                        MessageBox.Show("Registration failed. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }
    }
}
