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
using Microsoft.Data.Sqlite;
namespace Shopping_Mart_Application
{
    public partial class DetailsAndSearchForm : Form
    {
        private readonly string connectionString;
        public DetailsAndSearchForm()
        {
            InitializeComponent();
            SQLitePCL.Batteries.Init();
            connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            BindGridView();
            textBoxSearch.KeyDown += InputField_KeyDown;
        }
        private void InputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound on Enter
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }
        private void BindGridView()
        {
            // Define the SQL query to select all items with joined data
            string sql = @"
    SELECT 
        B.invoice_Id,
        A.UserName,
        A.DateTime,
        B.item_name,
        B.item_price,
        B.item_discount,
        B.quantity,
        B.tax,
        B.subtotal,
        B.totalcost,
        A.FinalCost
    FROM 
        order_master AS A
    INNER JOIN 
        order_details AS B 
    ON 
        B.invoice_Id = A.InvoiceId;";

            try
            {
                using (var connection = new SqliteConnection(connectionString))
                using (var command = new SqliteCommand(sql, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        // Initialize DataTable to load data from reader
                        DataTable dt = new DataTable();
                        dt.Load(reader); // Load data directly into DataTable

                        // Check if data was loaded into DataTable
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found for the query. Verify the data in order_master and order_details tables.",
                                            "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Bind DataTable to DataGridView
                        dataGridView.DataSource = dt;
                        dataGridView.Columns[10].Visible = false;
                        textBoxFinalCost.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., connection issues or SQL errors)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Define the SQL query with a parameter for safe searching
            string sql = @"
        SELECT 
            B.invoice_Id,
            A.UserName,
            A.DateTime,
            B.item_name,
            B.item_price,
            B.item_discount,
            B.quantity,
            B.tax,
            B.subtotal,
            B.totalcost,
            A.FinalCost
        FROM 
            order_master AS A
        INNER JOIN 
            order_details AS B 
        ON 
            B.invoice_Id = A.InvoiceId
        WHERE 
           B.invoice_Id LIKE @searchText;";

            try
            {
                using (var connection = new SqliteConnection(connectionString))
                using (var command = new SqliteCommand(sql, connection))
                {
                    // Add the search parameter with wildcards for partial matching
                    command.Parameters.AddWithValue("@searchText", $"%{textBoxSearch.Text}%");

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        // Initialize DataTable to load data from reader
                        DataTable dt = new DataTable();
                        dt.Load(reader); // Load data directly into DataTable

                        // Bind DataTable to DataGridView
                        dataGridView.DataSource = dt;
                        dataGridView.Columns[10].Visible = false;
                        textBoxFinalCost.Text = dataGridView.Rows[0].Cells[10].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., connection issues or SQL errors)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            // Define the SQL query with parameters for safe date range searching
            string sql = @"
    SELECT 
        B.invoice_Id,
        A.UserName,
        A.DateTime,
        B.item_name,
        B.item_price,
        B.item_discount,
        B.quantity,
        B.tax,
        B.subtotal,
        B.totalcost,
        A.FinalCost
    FROM 
        order_master AS A
    INNER JOIN 
        order_details AS B 
    ON 
        B.invoice_Id = A.InvoiceId
    WHERE 
        A.DateTime BETWEEN @firstdate AND @lastdate;";

            try
            {
                using (var connection = new SqliteConnection(connectionString))
                using (var command = new SqliteCommand(sql, connection))
                {
                    // Format dates as "yyyy-MM-dd HH:mm:ss" for SQLite
                    string firstDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss tt");
                    string lastDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss tt");

                    // Add parameters
                    command.Parameters.AddWithValue("@firstdate", firstDate);
                    command.Parameters.AddWithValue("@lastdate", lastDate);


                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        // Initialize DataTable to load data from reader
                        DataTable dt = new DataTable();
                        dt.Load(reader); // Load data directly into DataTable

                        // Bind DataTable to DataGridView
                        dataGridView.DataSource = dt;

                        // Optionally hide the FinalCost column (index may vary)
                        if (dt.Columns.Count > 10)
                        {
                            dataGridView.Columns[10].Visible = false;
                            // Display FinalCost in a TextBox
                            textBoxFinalCost.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., connection issues or SQL errors)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonReset_Click(object sender, EventArgs e)
        {
            BindGridView();
        }
    }
}
