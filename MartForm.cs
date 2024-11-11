using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Shopping_Mart_Application
{
    public partial class RoyalMartForm : Form
    {
        private readonly string connectionString;
        int srNo = 0, finalCost;

        public RoyalMartForm()
        {
            InitializeComponent();
            SQLitePCL.Batteries.Init();
            connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            textBoxInvoice.Text = GetInvoiceId().ToString();
            textBoxUser.Text = loginForm.userName;
            // Initialize DataGridView settings after InitializeComponent
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Ensure dataGridView is initialized
            if (dataGridView == null)
            {
                dataGridView = new DataGridView();
            }

            dataGridView.ColumnCount = 8;
            dataGridView.Columns[0].Name = "SR NO";
            dataGridView.Columns[1].Name = "ITEM NAME";
            dataGridView.Columns[2].Name = "UNIT PRICE";
            dataGridView.Columns[3].Name = "DISCOUNT PER ITEM";
            dataGridView.Columns[4].Name = "QUANTITY";
            dataGridView.Columns[5].Name = "SUB TOTAL";
            dataGridView.Columns[6].Name = "TAX";
            dataGridView.Columns[7].Name = "TOTAL COST";
        }



        // Method to get data from the database
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            using (var connection = new SqliteConnection(connectionString))
            {
                string sql = "SELECT * FROM items_Tbl";
                using (var cmd = new SqliteCommand(sql, connection))
                {
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new Item instance
                            var item = new Item
                            {
                                ItemName = reader.GetString(1), // 2nd column
                                ItemPrice = reader.GetInt32(2), // 3rd column
                                ItemDiscount = reader.GetInt32(3), // 4th column
                                Quantity = 1 // Default quantity
                            };

                            items.Add(item); // Add item to the list
                        }
                    }
                }
            }

            return items; // Return the list of items
        }

        private List<Item> itemList = new List<Item>();

        private void MartForm_Load(object sender, EventArgs e)
        {
            // Retrieve the list of items
            itemList = GetItems();

            // Clear existing items in the combo box (optional)
            comboBoxItem.Items.Clear();

            // Populate the combo box with item names
            foreach (var item in itemList)
            {
                comboBoxItem.Items.Add(item.ItemName); // Add only the item name to the combo box
            }
            comboBoxItem.Sorted = true;
        }

        public void GetItemsWithCounting(string name, int quantity)
        {
            foreach (var item in itemList)
            {
                if (item.ItemName == name)
                {
                    textBoxQuantity.Text = quantity.ToString();
                    textBoxUnitPrice.Text = item.ItemPrice.ToString();
                    textBoxDiscount.Text = item.ItemDiscount.ToString();
                    textBoxSubtotal.Text = ((item.ItemPrice - item.ItemDiscount) * quantity).ToString();
                    break;
                }
            }
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxItem.SelectedIndex != -1)
            {
                textBoxQuantity.Enabled = true;
                int quantity = Convert.ToInt32(string.IsNullOrEmpty(textBoxQuantity.Text) ? "1" : textBoxQuantity.Text); // by default 1 unit
                string name = comboBoxItem.Text;
                GetItemsWithCounting(name, quantity);
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {


            if (comboBoxItem.SelectedIndex != -1)
            {
                int quantity = Convert.ToInt32(string.IsNullOrEmpty(textBoxQuantity.Text) ? "0" : textBoxQuantity.Text);
                string name = comboBoxItem.Text;
                if (quantity > 0)
                {
                    GetItemsWithCounting(name, quantity);
                }
                else
                {

                    textBoxSubtotal.Text = "0";
                    textBoxQuantity.Text = "0";

                }
            }
            else
            {
                ResetControls();
            }
        }

        private void textBoxSubtotal_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedIndex != -1)
            {
                int subTotal = Convert.ToInt32(textBoxSubtotal.Text);
                if (subTotal >= 10000)
                {
                    textBoxTax.Text = ((int)(subTotal * 0.15)).ToString();
                }
                else if (subTotal >= 5000)
                {
                    textBoxTax.Text = ((int)(subTotal * 0.10)).ToString();
                }
                else if (subTotal >= 3000)
                {
                    textBoxTax.Text = ((int)(subTotal * 0.06)).ToString();
                }
                else if (subTotal >= 1000)
                {
                    textBoxTax.Text = ((int)(subTotal * 0.04)).ToString();
                }
                else
                {
                    textBoxTax.Text = ((int)(subTotal * 0.01)).ToString();
                }
                textBoxTotal.Text = (subTotal + Convert.ToInt32(textBoxTax.Text)).ToString();
            }
        }
        void AddDataToGridView(string sr_no, string item_name, string unit_price, string discount, string quantity, string subtotal, string tax, string total_cost)
        {
            string[] row = { sr_no, item_name, unit_price, discount, quantity, subtotal, tax, total_cost };

            dataGridView.Rows.Add(row);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedIndex != -1)
            {
                textBoxPaid.Text = "";
                textBoxChange.Text = "";
                dataGridView.Visible = true;
                AddDataToGridView((++srNo).ToString(), comboBoxItem.SelectedItem.ToString(), textBoxUnitPrice.Text, textBoxDiscount.Text, textBoxQuantity.Text, textBoxSubtotal.Text, textBoxTax.Text, textBoxTotal.Text);
                CalculateFinalCost();
                ResetControls();
                clear_Btn.Visible = true;
            }
            else
            {
                // dataGridView.Visible = false;   
                MessageBox.Show("Please seletc an item first");
            }
        }
        private void ResetControls()
        {

            comboBoxItem.SelectedIndex = -1;
            textBoxDiscount.Text = "";
            textBoxQuantity.Text = "";
            textBoxSubtotal.Text = "";
            textBoxTax.Text = "";
            textBoxTotal.Text = "";
            textBoxUnitPrice.Text = "";
            textBoxQuantity.Enabled = false;
            comboBoxItem.Focus();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetControls();
            textBoxFinalCost.Text = "";
            textBoxChange.Text = "";
            textBoxPaid.Text = "";
        }
        private void CalculateFinalCost()
        {
            finalCost = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                finalCost += Convert.ToInt32(dataGridView.Rows[i].Cells[7].Value);
            }
            // MessageBox.Show("final cost "+finalCost);

            textBoxFinalCost.Text = finalCost.ToString();
        }

        private void textBoxPaid_TextChanged(object sender, EventArgs e)
        {

            int amount = 0, totalCost = 0;
            if (textBoxPaid.Text.Length > 0)
            {
                amount = Convert.ToInt32(textBoxPaid.Text);

            }
            else
            {
                textBoxChange.Text = "";
            }
            if (textBoxFinalCost.Text.Length > 0)
            {
                totalCost = Convert.ToInt32(textBoxFinalCost.Text);
            }

            if (totalCost > 0)
            {
                amount -= totalCost;
                if (amount > 0) { textBoxChange.Text = amount.ToString(); }

            }
            else
            {

                MessageBox.Show("First Select item to buy");
                textBoxPaid.Text = "";
            }



        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            srNo = 0;
            dataGridView.Rows.Clear();
        }

        private int GetInvoiceId()
        {
            int newInvoiceId;

            using (var connection = new SqliteConnection(connectionString))
            {
                string sql = "SELECT MAX(InvoiceId) FROM order_master";

                using (var cmd = new SqliteCommand(sql, connection))
                {
                    connection.Open();

                    // Execute the command and retrieve the maximum InvoiceId
                    object result = cmd.ExecuteScalar();

                    // Check if result is null (no rows in the table)
                    newInvoiceId = (result == DBNull.Value || result == null) ? 1 : Convert.ToInt32(result) + 1;
                }
            }

            return newInvoiceId; // Return the new InvoiceId
        }
        private void InsertIntoOrderDetails()
        {
            using (var connection = new SqliteConnection(connectionString))
            {



                int invoiceId = Convert.ToInt32(textBoxInvoice.Text), a = 0;
                try
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        string sql = "INSERT INTO order_details (invoice_Id, item_name, item_price, item_discount, quantity, subtotal, tax, totalcost) " +
                          "VALUES (@invoiceId, @itemName, @itemPrice, @itemDiscount, @quantity, @subtotal, @tax, @totalCost);";
                        using (var cmd = new SqliteCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                            cmd.Parameters.AddWithValue("@itemName", dataGridView.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@itemPrice", dataGridView.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@itemDiscount", dataGridView.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@quantity", dataGridView.Rows[i].Cells[4].Value);
                            cmd.Parameters.AddWithValue("@subtotal", dataGridView.Rows[i].Cells[5].Value);
                            cmd.Parameters.AddWithValue("@tax", dataGridView.Rows[i].Cells[6].Value);
                            cmd.Parameters.AddWithValue("@totalCost", dataGridView.Rows[i].Cells[7].Value);
                            connection.Open();
                            a += cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }

                }
                catch
                {

                }
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFinalCost.Text))
            {
                MessageBox.Show("Buy some item first", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO order_master (InvoiceId, UserName, DateTime, FinalCost) VALUES (@InvoiceId, @UserName, @DateTime, @FinalCost)";

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    // Use GetInvoiceId to get a new InvoiceId
                    cmd.Parameters.AddWithValue("@InvoiceId", GetInvoiceId());
                    cmd.Parameters.AddWithValue("@UserName", textBoxUser.Text);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                    cmd.Parameters.AddWithValue("@FinalCost", Convert.ToDecimal(textBoxFinalCost.Text)); // Use decimal for currency

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // ExecuteNonQuery for insert

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data insertion into order_master table was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception message for debugging (optional)
                Console.WriteLine(ex.Message); // Consider using a logging framework
                MessageBox.Show("An unexpected error occurred. Please try again later.", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ResetControls();
                InsertIntoOrderDetails();
                textBoxInvoice.Text = GetInvoiceId().ToString();
            }

        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input if it's not a digit
            }
        }

        private void textBoxPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input if it's not a digit
            }
        }

        private void PreviewqBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // If 'royal_mart' is a byte array, convert it to an Image
            byte[] imageBytes = Properties.Resources.royal_mart; // Adjust if the name is different
            using (var ms = new MemoryStream(imageBytes))
            {
                using (var img = Image.FromStream(ms))
                {
                    // Draw the image on the print document
                    e.Graphics.DrawImage(img, new Rectangle(26, 25, 800, 250));
                }
            }
            e.Graphics.DrawString("Invoice Id    :  " + textBoxInvoice.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("User Name :  " + textBoxUser.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date              :  " + DateTime.Now.ToShortDateString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Time              :  " + DateTime.Now.ToShortTimeString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 420));
            e.Graphics.DrawString("ITEM", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("UNIT PREICE ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(210, 450));
            e.Graphics.DrawString("DISCOUNT ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(410, 450));
            e.Graphics.DrawString("QUANTITY ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(640, 450));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 480));
            int gap = 510, subTotal = 0, Tax = 0, finalAmount = 0, change = 0, paid = 0;

            if (dataGridView.Rows.Count > 0)
            {

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap));
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(250, gap));
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(450, gap));
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(680, gap));
                        gap += 30;
                        subTotal += Convert.ToInt32(dataGridView.Rows[i].Cells[5].Value.ToString());
                        Tax += Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value.ToString());

                    }
                    catch
                    {

                    }

                }
            }
            finalAmount = subTotal + Tax;
            if (textBoxPaid.Text.Length > 0)
            {
                paid = Convert.ToInt32(textBoxPaid.Text);
                change = paid - finalAmount;
            }


            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap + 250));

            e.Graphics.DrawString("Sub-Total        :  " + subTotal.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap + 280));
            e.Graphics.DrawString("Tax                   :  " + Tax.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap + 310));
            e.Graphics.DrawString("Final Amount :  " + finalAmount.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap + 340));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap + 370));
            e.Graphics.DrawString("Amount Paid  :  " + paid.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap + 400));
            e.Graphics.DrawString("Change           :  " + change.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap + 430));







        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm();
            add.ShowDialog();

        }

        private void RoyalMartForm_Activated(object sender, EventArgs e)
        {
            // Retrieve the list of items
            itemList = GetItems();

            // Clear existing items in the combo box (optional)
            comboBoxItem.Items.Clear();

            // Populate the combo box with item names
            foreach (var item in itemList)
            {
                comboBoxItem.Items.Add(item.ItemName); // Add only the item name to the combo box
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItemForm edit = new EditItemForm();
            edit.ShowDialog();

        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDataForm view = new ViewDataForm();
            view.ShowDialog();
        }

        private void detailsAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsAndSearchForm details = new DetailsAndSearchForm();
            details.ShowDialog();
        }

        private void RoyalMartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {       
                  HelpForm help=new HelpForm();
                  help.ShowDialog();
        }
    }


}


  