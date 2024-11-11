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
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.Sqlite;
namespace Shopping_Mart_Application
{
    public partial class ViewDataForm : Form
    {
        private readonly string connectionString;
        public ViewDataForm()
        {
            InitializeComponent();
            SQLitePCL.Batteries.Init();
            connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            BindGridView();
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

        private void ViewDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RoyalMartForm r = new RoyalMartForm();
            r.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm(); add.ShowDialog();
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EditItemForm edit = new EditItemForm(); edit.ShowDialog();
          
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            EditItemForm edit = new EditItemForm(); edit.ShowDialog(); 
        }

        private void ViewDataForm_Activated(object sender, EventArgs e)
        {
            BindGridView();
        }
    }
}
