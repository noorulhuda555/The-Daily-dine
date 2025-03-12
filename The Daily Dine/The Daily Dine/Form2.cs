using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Daily_Dine
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=123456;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
                    label5.Text = Convert.ToInt32(new MySqlCommand(cashierQuery, conn).ExecuteScalar()).ToString(); //returj count

                    string customerQuery = "SELECT COUNT(*) FROM customers"; //tells count of customers 
                    label6.Text = Convert.ToInt32(new MySqlCommand(customerQuery, conn).ExecuteScalar()).ToString();

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
    }
}