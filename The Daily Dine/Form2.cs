using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Daily_Dine
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateCustomerCount();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string cashierQuery = "SELECT COUNT(*) FROM users WHERE role = 'cashier'"; //count no. cashiers 
                  //  label5.Text = Convert.ToInt32(new MySqlCommand(cashierQuery, conn).ExecuteScalar()).ToString(); //returj count

                    string customerQuery = "SELECT COUNT(*) FROM customers"; //tells count of customers 
                    //label6.Text = Convert.ToInt32(new MySqlCommand(customerQuery, conn).ExecuteScalar()).ToString();

                    //return zero if no income for current date 
                    string todayIncomeQuery = "SELECT COALESCE(SUM(amount), 0) FROM orders WHERE DATE(order_date) = CURDATE()";
                    label7.Text = $"${Convert.ToDecimal(new MySqlCommand(todayIncomeQuery, conn).ExecuteScalar()):F2}";

                    //income total 
                    string totalIncomeQuery = "SELECT COALESCE(SUM(amount), 0) FROM orders";
                    label8.Text = $"${Convert.ToDecimal(new MySqlCommand(totalIncomeQuery, conn).ExecuteScalar()):F2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e) //logout button clicked
        {
            new Form3().Show(); //move to log in 
            Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 rw = new Form6();
            rw.Show();
            this.Hide(); // Hide (not close)  to keep the app running

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 rw = new Form7();
            rw.Show();
            this.Hide(); // Hide (not close) to keep the app running
        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            UpdateCustomerCount();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            UpdateCustomerCount();
        }
        private void UpdateCustomerCount()
        {
            string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";
            int totalCustomers = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Count customers in reservations
                    string reservationQuery = "SELECT COUNT(*) FROM table_reservations";
                    using (MySqlCommand reservationCmd = new MySqlCommand(reservationQuery, conn))
                    {
                        totalCustomers += Convert.ToInt32(reservationCmd.ExecuteScalar());
                    }

                    // Count customers in waitlist
                    string waitlistQuery = "SELECT COUNT(*) FROM waitlist_customers";
                    using (MySqlCommand waitlistCmd = new MySqlCommand(waitlistQuery, conn))
                    {
                        totalCustomers += Convert.ToInt32(waitlistCmd.ExecuteScalar());
                    }
                }

                // Update the label with the total customers
                customer.Text = "Total Customers: " + totalCustomers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting customers: " + ex.Message);
            }
        }

        private void today_income_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(amount) FROM orders WHERE DATE(order_date) = CURDATE()"; // Only today

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            decimal todayIncome = Convert.ToDecimal(result);
                            MessageBox.Show("Today's Income: Rs. " + todayIncome.ToString("N2"));
                        }
                        else
                        {
                            MessageBox.Show("No income recorded for today yet.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching today's income: " + ex.Message);
            }
        }


        private void Total_Income_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(amount) FROM orders"; // Sum all orders

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            decimal totalIncome = Convert.ToDecimal(result);
                            MessageBox.Show("Total Income: Rs. " + totalIncome.ToString("N2"));
                        }
                        else
                        {
                            MessageBox.Show("No income recorded yet.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total income: " + ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void cashiers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 rw = new Form8();
            rw.Show();
            this.Hide();
        }
    }
}