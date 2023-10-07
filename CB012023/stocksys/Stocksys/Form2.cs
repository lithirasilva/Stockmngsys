using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stocksys
{
    internal partial class Form2 : Form
    {
        private SqlConnection con;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=lithilaptop;Initial Catalog=StockTbl;User ID=sa;Password=SQL123@#");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get input values from the user
            string stockCode = textBox1.Text;
            string stockName = textBox2.Text;
            int stockQuantity = Int32.Parse(textBox3.Text);
            DateTime stockDate = DateTime.Now;

            try
            {
                con.Open();

                // Check if an item with the same code or name already exists
                if (IsItemExists(stockCode, stockName))
                {
                    MessageBox.Show("An item with the same code or name already exists.");
                }
                else
                {
                    string transactionType = "Item added";

                    // Create a Stock object and insert it into the database
                    StockTransact stockItem = new StockTransact(stockCode, stockName, stockQuantity, stockDate, transactionType);
                    InsertNewItem(stockItem);

                    MessageBox.Show("Successfully Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void InsertNewItem(StockTransact stockItem)
        {
            // Insert a new item into the database
            SqlCommand insertCommand = new SqlCommand("INSERT INTO stockTable (StockCode, StockName, StockQuantity, DateTime, TransactionType) VALUES (@stockCode, @stockName, @stockQuantity, @DateTime, @TransactionType)", con);
            insertCommand.Parameters.AddWithValue("@stockCode", stockItem.StockCode);
            insertCommand.Parameters.AddWithValue("@stockName", stockItem.StockName);
            insertCommand.Parameters.AddWithValue("@stockQuantity", stockItem.StockQuantity);
            insertCommand.Parameters.AddWithValue("@DateTime", stockItem.DateTime);
            insertCommand.Parameters.AddWithValue("@TransactionType", stockItem.TransactionType);

            insertCommand.ExecuteNonQuery();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Load and display items from the database
            LoadItemsFromDatabase();
        }

        private bool IsItemExists(string stockCode, string stockName)
        {
            // Check if an item with the same code or name exists in the database
            SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM stockTable WHERE StockCode = @stockCode OR StockName = @stockName", con);
            checkCommand.Parameters.AddWithValue("@stockCode", stockCode);
            checkCommand.Parameters.AddWithValue("@stockName", stockName);

            int itemCount = (int)checkCommand.ExecuteScalar();

            return itemCount > 0;
        }

        private void InsertNewItem(string stockCode, string stockName, int stockQuantity, DateTime stockDate, string transactionType)
        {
            // Insert a new item into the database
            SqlCommand insertCommand = new SqlCommand("INSERT INTO stockTable (StockCode, StockName, StockQuantity, DateTime, TransactionType) VALUES (@stockCode, @stockName, @stockQuantity, @DateTime, @TransactionType)", con);
            insertCommand.Parameters.AddWithValue("@stockCode", stockCode);
            insertCommand.Parameters.AddWithValue("@stockName", stockName);
            insertCommand.Parameters.AddWithValue("@stockQuantity", stockQuantity);
            insertCommand.Parameters.AddWithValue("@DateTime", stockDate);
            insertCommand.Parameters.AddWithValue("@TransactionType", transactionType);

            insertCommand.ExecuteNonQuery();
        }

        private void LoadItemsFromDatabase()
        {
            // Load items from the database and display them in a DataGridView
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT StockCode, StockName, StockQuantity, DateTime, TransactionType FROM stockTable", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                sd.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
