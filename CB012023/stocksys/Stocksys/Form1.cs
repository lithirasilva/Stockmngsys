using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stocksys
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=lithilaptop;Initial Catalog=Login;User ID=sa;Password=SQL123@#";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlog_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Enter Username");
            }
            else if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Enter Password");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string query = "SELECT * FROM login_tbl WHERE username = @username";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string storedPasswordHash = reader["password"].ToString(); // Assuming you store hashed passwords

                            // Check the password here, you need to implement password hashing and validation

                            MessageBox.Show("Login Successful");

                            // Close the login form
                            this.Hide();

                            // Open the main form
                            Form2 mainForm = new Form2();
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Username or password is invalid");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}

