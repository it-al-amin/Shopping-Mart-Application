using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Mart_Application
{
    public partial class loginForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        public static string userName = "";
        public object MessageBoxIcons { get; private set; }

        public loginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            // Attach KeyPress event handlers
            txtUser.KeyPress += TxtUser_KeyPress;
            txtPassword.KeyPress += TxtPassword_KeyPress;
        }
        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevents the beep sound
                txtPassword.Focus(); // Move focus to the password TextBox
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevents the beep sound
                LoginBtn.Focus(); // Go to the login button
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            errorProvider1.Clear();
            errorProvider2.Clear();

            // Validate input fields
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                errorProvider1.SetError(txtUser, "Username cannot be empty.");
                txtUser.Focus();
                return; // Exit the method if validation fails
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider2.SetError(txtPassword, "Password cannot be empty.");
                txtPassword.Focus();
                return; // Exit the method if validation fails
            }

            // Trim input
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Prepare the SQL query with parameters
            string sql = "SELECT * FROM UserSignup_tbl WHERE Name = @username AND Password = @password";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        // Load the DataTable with the data from the reader
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Check if any rows were returned
                        if (dt.Rows.Count > 0)
                        {
                            userName = username; // Store the username for later use
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Handle successful login (e.g., navigate to the main form)
                            this.Hide();
                            RoyalMartForm form = new RoyalMartForm();
                            form.Show();
                          

                        }
                        else
                        {
                            // Invalid credentials
                            MessageBox.Show("Invalid username or password.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("SQLite error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("An invalid operation occurred: " + ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Optionally log the exception (e.g., to a file or logging system)
                // LogError(ex); // Implement this method to handle logging as needed

                MessageBox.Show("An unexpected error occurred. Please try again later.", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clear input fields after processing
                txtUser.Clear();
                txtPassword.Clear();
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm su=new SignupForm();
            this.Hide();
            su.ShowDialog();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check=checkBox.Checked;
            if (check) { 
            txtPassword.UseSystemPasswordChar = true;   
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }


        }
    }
}
