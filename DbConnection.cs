using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data;


namespace Shopping_Mart_Application
{
    public class DbConnection
    {

        // Properties acting as data carriers in the application
        public int item_id { get; set; }
        public string item_name { get; set; }
        public int item_price { get; set; }
        public int item_discount { get; set; }
        public int RowIndex { get; internal set; }

        // Get the connection string from App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

        // Method to select data from the database
        
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            // Check if connection string is not empty or null
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not configured properly.");
                return dt;
            }

            string sql = "SELECT * FROM items_Tbl";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        conn.Open();

                        using (var reader = cmd.ExecuteReader())
                        {
                            // Load the DataTable with the data from the reader
                            dt.Load(reader); // This will fill the DataTable directly from the reader
                        }
                        conn.Close();
                    }

                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("SQLite error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return dt;
        }

        // Method to insert a new item into the database
        public bool Insert()
        {
            string sql = "INSERT INTO items_Tbl (item_id, item_name, item_price, item_discount) VALUES (@item_id, @item_name, @item_price, @item_discount)";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@item_id", item_id);
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@item_price", item_price);
                        cmd.Parameters.AddWithValue("@item_discount", item_discount);

                        conn.Open();
                        int rt = cmd.ExecuteNonQuery();
                        conn.Close();
                        return rt > 0;
                    }
                   
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("SQLite error occurred: " + ex.Message);
                return false;
            }
        }

        // Method to update an existing item in the database
        public bool Update()
        {
            string sql = "UPDATE items_Tbl SET item_name = @item_name, item_price = @item_price, item_discount = @item_discount WHERE item_id = @item_id";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@item_id", item_id);
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@item_price", item_price);
                        cmd.Parameters.AddWithValue("@item_discount", item_discount);

                        conn.Open();
                        int rt = cmd.ExecuteNonQuery(); 
                        conn.Close();
                        return rt>0;// Returns true if row is updated
                    }
                   
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("SQLite error occurred: " + ex.Message);
                return false;
            }
        }

        // Method to delete an item from the database
        public bool Delete()
        {
            string sql = "DELETE FROM items_Tbl WHERE item_id = @item_id";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@item_id", item_id);

                        conn.Open();
                        int rt = cmd.ExecuteNonQuery();
                        conn.Close();
                        return rt > 0;
                    }
                    
                }
            
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("SQLite error occurred: " + ex.Message);
                return false;
            }
        }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int ItemDiscount { get; set; }
        public int Quantity { get; set; } = 1; // Default quantity
    }


}
