using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static The_Daily_Dine.sessionManager;

namespace The_Daily_Dine
{
    public partial class Form4 : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button6.Click += new EventHandler(button6_Click); // Manually wire button event
            button1.Click += new EventHandler(button1_Click);
        }

        // Function to get user ID from the users table based on username
        private int GetUserId(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id FROM users WHERE username = @username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        object result = cmd.ExecuteScalar(); // Get single value (user id)
                        return result != null ? Convert.ToInt32(result) : -1; // Return -1 if not found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching user ID: " + ex.Message);
                    return -1;
                }
            }
        }

        // Function to update username in the users table
        private bool UpdateUsername(string newUsername, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected to Database!");  // Debugging Message

                    string query = "UPDATE users SET username = @newUsername WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newUsername", newUsername);
                        cmd.Parameters.AddWithValue("@id", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Rows Affected: {rowsAffected}");  // Debugging Message

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating username: " + ex.Message);
                    return false;
                }
            }
        }

        // Function to update address in the users table
        private bool UpdateAddress(string newAddress, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected to Database! Updating Address..."); // Debugging Message

                    string query = "UPDATE users SET address = @newAddress WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newAddress", newAddress);
                        cmd.Parameters.AddWithValue("@id", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Rows Affected (Address): {rowsAffected}"); // Debugging Message

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating address: " + ex.Message);
                    return false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInUsername == null)
            {
                MessageBox.Show("SessionManager.LoggedInUsername is NULL!");
                return;
            }
            if (SessionManager.LoggedInUsername == "")
            {
                MessageBox.Show("SessionManager.LoggedInUsername is EMPTY!");
                return;
            }

            MessageBox.Show("Current Username: " + SessionManager.LoggedInUsername); // Debugging

            int userId = GetUserId(SessionManager.LoggedInUsername);
            MessageBox.Show("User ID: " + userId); // Debugging

            if (userId == -1)
            {
                MessageBox.Show("User not found in database!");
                return;
            }

            // Updating Username
            string newUsername = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Username field cannot be empty.");
                return;
            }

            bool success = UpdateUsername(newUsername, userId);
            if (success)
                MessageBox.Show("Username updated successfully.");
            else
                MessageBox.Show("Failed to update username.");

            // Updating Address
            string newAddress = textBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(newAddress))
            {
                MessageBox.Show("Address field cannot be empty.");
                return;
            }

            bool addressSuccess = UpdateAddress(newAddress, userId);
            if (addressSuccess)
                MessageBox.Show("Address updated successfully.");
            else
                MessageBox.Show("Failed to update address.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Implement real-time update if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Optional: Implement if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu menuForm = new menu(); // Create an instance of MenuForm
            menuForm.Show(); // Show the menu form
            this.Hide(); // Hide the current form (Form4)

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2(); // Create an instance of MenuForm
            newForm2.Show(); // Show the menu form
            this.Hide(); // Hide the current form (Form4)

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deals dealpage = new deals(); // Create an instance of MenuForm
            dealpage.Show(); // Show the menu form
            this.Hide(); // Hide the current form (Form4)

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
