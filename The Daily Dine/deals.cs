using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static The_Daily_Dine.sessionManager;

namespace The_Daily_Dine
{
    public partial class deals : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";
        private List<(CheckBox checkBox, Label nameLabel, Label priceLabel, NumericUpDown quantity)> dealsList;

        public deals()
        {
            InitializeComponent();
            InitializeDeals();
        }

        private void InitializeDeals()
        {
            dealsList = new List<(CheckBox, Label, Label, NumericUpDown)>
            {
                (checkBox1, label1, label2, numericUpDown1),
                (checkBox2, label3, label4, numericUpDown2),
                (checkBox3, label5, label6, numericUpDown3),
                (checkBox4, label7, label8, numericUpDown4),
                (checkBox5, label9, label10, numericUpDown5),
                (checkBox6, label11, label12, numericUpDown6)
            };
        }

        private void AddDealToCart(string dealName, decimal price, int quantity)
        {
            decimal totalPrice = price * quantity; // Calculate total price
            string query = "INSERT INTO cart (item_name, price, quantity) VALUES (@name, @price, @quantity)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", dealName);
                    cmd.Parameters.AddWithValue("@price", totalPrice);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AddSelectedDealsToCart()
        {
            bool dealAdded = false;

            foreach (var deal in dealsList)
            {
                if (deal.checkBox.Checked) // If deal is selected
                {
                    string dealName = deal.nameLabel.Text;
                    decimal price = Convert.ToDecimal(deal.priceLabel.Text);
                    int quantity = (int)deal.quantity.Value;

                    if (quantity > 0) // Ensure quantity is greater than 0
                    {
                        AddDealToCart(dealName, price, quantity);
                        dealAdded = true;
                    }
                }
            }

            if (dealAdded)
            {
                MessageBox.Show("Selected deals added to cart!");
            }
            else
            {
                MessageBox.Show("No deals selected or quantity is 0!");
            }
        }

        private void deals_Load(object sender, EventArgs e)
        {
            InitializeDeals();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSelectedDealsToCart();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (SessionManager.CurrentUserId > 0) // Check if user is logged in
            {
                bill billForm = new bill(SessionManager.CurrentUserId);
                billForm.Show(); // Open the bill form
            }
            else
            {
                MessageBox.Show("User not logged in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
