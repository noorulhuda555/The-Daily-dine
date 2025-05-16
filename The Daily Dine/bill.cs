using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace The_Daily_Dine
{
    public partial class bill : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

        private int currentUserId;
        public bill(int userId)
        {

            InitializeComponent();
            currentUserId = userId;
            MessageBox.Show("User ID: " + currentUserId.ToString()); // Debugging check
            LoadBill();


        }




        //donot modify 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadBill()
        {
            // Query to fetch cart details along with total bill calculation
            //string query = "SELECT item_name, added_at, price, quantity, (price * quantity) AS total_price FROM cart WHERE user_id = @userId AND added_at = ";
            string query = "SELECT item_name, added_at, price, quantity, (price * quantity) AS total_price FROM cart WHERE user_id = @userId AND added_at >= NOW() - INTERVAL 1 MINUTE";

            // Query to fetch username
            string userQuery = "SELECT username FROM users WHERE id = @userId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Fetch username
                using (MySqlCommand userCmd = new MySqlCommand(userQuery, conn))
                {
                    userCmd.Parameters.AddWithValue("@userId", currentUserId);
                    object result = userCmd.ExecuteScalar();
                    if (result != null)
                    {
                        label2.Text = "User: " + result.ToString(); // Display username
                    }
                    else
                    {
                        label2.Text = "User: Unknown";
                    }
                }

                // Fetch cart details
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No items found in cart for this user.");
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;

                        // Calculate total price
                        decimal total = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            total += Convert.ToDecimal(row["total_price"]);
                        }

                        label1.Text = "Total Bill: Rs. " + total.ToString("N2"); // Update total bill
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false; // Uncheck Cash on Delivery
                textBox1.Enabled = true;   // Enable Card Number field
                textBox2.Enabled = true;   // Enable Card Code field
            }
            else
            {
                textBox1.Enabled = false;  // Disable Card Number field
                textBox2.Enabled = false;  // Disable Card Code field
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false; // Uncheck Credit/Debit Card

                // Check if the user has an address
                string query = "SELECT address FROM users WHERE id = @userId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        object result = cmd.ExecuteScalar();

                        if (result == null || string.IsNullOrWhiteSpace(result.ToString()))
                        {
                            MessageBox.Show("No address found! Please update your profile.");
                            checkBox2.Checked = false; // Uncheck if no address is found
                        }
                    }
                }
            }
        }

        // Restrict input to numbers only for Card Number (16 digits)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }
        }

        // Restrict input to numbers only for Security Code (4 digits)
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 16; // Set max length for card number
            textBox2.MaxLength = 4;  // Set max length for security code

            // Attach key press events to restrict input
            textBox1.KeyPress += textBox1_KeyPress;
            textBox2.KeyPress += textBox2_KeyPress;
        }



        private void textBox1_TextChanged(object sender, EventArgs e) //card number
        {//must be 16 digits 


        }

        private void textBox2_TextChanged(object sender, EventArgs e) //code for card
        {  //4 digits code verify from user_account table 

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked) // Cash on Delivery selected
            {
                MessageBox.Show("Cash on Delivery selected. No card details required.");
                SaveOrderToDatabase();
                return;
            }

            string cardNumber = textBox1.Text.Trim();
            string cardCode = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(cardCode))
            {
                MessageBox.Show("Please enter both card number and security code.");
                return;
            }

            if (cardNumber.Length != 16 || cardCode.Length != 4)
            {
                MessageBox.Show("Card number must be 16 digits and security code must be 4 digits.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if the user already has a card saved
                string checkQuery = "SELECT card_number, card_code FROM user_account WHERE user_id = @userId";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@userId", currentUserId);
                    using (MySqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string existingCardNumber = reader["card_number"].ToString();
                            reader.Close();

                            if (existingCardNumber == cardNumber)
                            {
                                MessageBox.Show("Card already linked to this account.");
                                SaveOrderToDatabase();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("A different card is already linked to this account.");
                                return;
                            }
                        }
                        reader.Close(); // Must close reader before running another query
                    }
                }

                // Insert card details into user_account table if no card exists
                string insertQuery = "INSERT INTO user_account (user_id, card_number, card_code) VALUES (@userId, @cardNumber, @cardCode)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@userId", currentUserId);
                    insertCmd.Parameters.AddWithValue("@cardNumber", cardNumber);
                    insertCmd.Parameters.AddWithValue("@cardCode", cardCode);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Card details saved successfully!");
                        SaveOrderToDatabase(); // Save the order only after successful card save
                    }
                    else
                    {
                        MessageBox.Show("Failed to save card details. Try again.");
                    }
                }
            }
        }

        private void SaveOrderToDatabase()
        {
            string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";
            decimal totalAmount = GetTotalBillAmount(); // Calculate from cart

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO orders (amount, order_date) VALUES (@amount, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@amount", totalAmount);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order saved successfully into the system!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the order. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting into orders: " + ex.Message);
            }
        }
        private decimal GetTotalBillAmount()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["total_price"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["total_price"].Value);
                }
            }

            return total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 dashboardForm = new Form2();
            dashboardForm.Show();
            Hide();
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
