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

    public partial class menu : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";
        private List<(CheckBox checkBox, Label nameLabel, Label priceLabel, NumericUpDown quantity)> menuItems;
        //private List<(CheckBox checkBox, Label nameLabel, Label priceLabel)> menuItems;
        public menu()
        {
            InitializeComponent();
            InitializeMenuItems();
        }

        private void InitializeMenuItems()
        {
            menuItems = new List<(CheckBox, Label, Label, NumericUpDown)>
            {
                (checkBox1, label1, label18, numericUpDown1),
                (checkBox2, label2, label17, numericUpDown2),
                (checkBox3, label3, label16, numericUpDown3),
                (checkBox4, label4, label15, numericUpDown4),
                (checkBox5, label5, label14, numericUpDown5),
                (checkBox6, label6, label13, numericUpDown6),
                (checkBox7, label7, label12, numericUpDown7),
                (checkBox8, label8, label11, numericUpDown8),
                (checkBox9, label9, label10, numericUpDown9),
                (checkBox10, label19, label28, numericUpDown10),
                (checkBox11, label20, label29, numericUpDown11),
                (checkBox12, label21, label30, numericUpDown12),
                (checkBox13, label22, label31, numericUpDown13),
                (checkBox14, label23, label32, numericUpDown14),
                (checkBox15, label24, label33, numericUpDown15),
                (checkBox16, label25, label34, numericUpDown16),
                (checkBox17, label26, label35, numericUpDown17),
                (checkBox18, label27, label36, numericUpDown18)
            };
        }

        private void AddToCart(string itemName, decimal price, int quantity)
        {
            if (SessionManager.CurrentUserId == 0)
            {
                MessageBox.Show("User not logged in! Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPrice = price * quantity;
            string query = "INSERT INTO cart (user_id, item_name, price, quantity) VALUES (@userId, @name, @price, @quantity)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", SessionManager.CurrentUserId);
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@price", totalPrice);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void AddSelectedItemsToCart()
        {
            bool itemAdded = false;

            foreach (var item in menuItems)
            {
                if (item.checkBox.Checked) // If checkbox is selected
                {
                    string itemName = item.nameLabel.Text;
                    decimal price = Convert.ToDecimal(item.priceLabel.Text); // Convert label text to decimal
                    int quantity = (int)item.quantity.Value; // Get selected quantity

                    if (quantity > 0) // Ensure quantity is greater than 0
                    {
                        AddToCart(itemName, price, quantity); // Pass quantity to the function
                        itemAdded = true;
                    }
                }
            }

            if (itemAdded)
            {
                MessageBox.Show("Selected items added to cart!");
            }
            else
            {
                MessageBox.Show("No items selected or quantity is 0!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMenuItems(); // Initialize UI mappings
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSelectedItemsToCart(); // Call function when button is clicked
        }


        //donot remove this 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //donot remove this please
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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

    
}




}
