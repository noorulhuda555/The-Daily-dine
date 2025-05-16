using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace The_Daily_Dine
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadWaitlist();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Your Delete button
        {
            if (dataGridViewWaitlist.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entry to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this waitlist entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridViewWaitlist.SelectedRows[0].Cells["ID"].Value);

                        string query = "DELETE FROM waitlist_customers WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Waitlist entry deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadWaitlist();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void textBoxTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaitlist.SelectedRows.Count > 0)
            {
                textBoxWaitlistName.Text = dataGridViewWaitlist.SelectedRows[0].Cells["Customer Name"].Value.ToString();
                comboBoxWaitlistSize.Text = dataGridViewWaitlist.SelectedRows[0].Cells["Group Size"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a waitlist entry to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ADD_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

            if (string.IsNullOrWhiteSpace(textBoxWaitlistName.Text) || comboBoxWaitlistSize.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO waitlist_customers (customer_name, group_size) VALUES (@customerName, @groupSize)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerName", textBoxWaitlistName.Text.Trim());
                        cmd.Parameters.AddWithValue("@groupSize", Convert.ToInt32(comboBoxWaitlistSize.SelectedItem));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer added to waitlist successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWaitlist();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buttonMoveToReservation_Click(object sender, EventArgs e)
        {
            Form6 rw = new Form6();
            rw.Show();
            this.Hide(); // Hide (not close) Form7 to keep the app running
        }

        private void textBoxWaitlistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadWaitlist(textBoxSearch.Text.Trim());
        }


        private void comboBoxWaitlistSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadWaitlist(string searchText = "")
        {
            string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id AS 'ID', customer_name AS 'Customer Name', group_size AS 'Group Size', added_at AS 'Added At' FROM waitlist_customers";

                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        query += " WHERE customer_name LIKE @search";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchText))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewWaitlist.DataSource = dt;
                        }
                    }
                }

                // Hide ID column
                if (dataGridViewWaitlist.Columns.Contains("ID"))
                {
                    dataGridViewWaitlist.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading waitlist: " + ex.Message);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewWaitlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewWaitlist.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        }
        public void PreFillWaitlist(string customerName, int groupSize)
        {
            textBoxWaitlistName.Text = customerName;
            comboBoxWaitlistSize.SelectedItem = groupSize;
        }
        private void MoveFromWaitlistIfPossible(string tableNumber)
        {
            string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string selectQuery = "SELECT * FROM waitlist_customers ORDER BY added_at ASC LIMIT 1";
                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string customerName = reader.GetString("customer_name");
                                int groupSize = reader.GetInt32("group_size");

                                reader.Close(); // Close reader before insert

                                // Insert into reservations
                                string insertQuery = "INSERT INTO table_reservations (customer_name, table_number, capacity) VALUES (@customerName, @tableNumber, @capacity)";
                                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@customerName", customerName);
                                    insertCmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                                    insertCmd.Parameters.AddWithValue("@capacity", groupSize);
                                    insertCmd.ExecuteNonQuery();
                                }

                                // Remove from waitlist
                                string deleteQuery = "DELETE FROM waitlist_customers WHERE id = @id";
                                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                                {
                                    deleteCmd.Parameters.AddWithValue("@id", reader.GetInt32("id"));
                                    deleteCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show($"Moved {customerName} from waitlist to table {tableNumber}!", "Waitlist Moved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error moving from waitlist: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            textBoxWaitlistName.Clear();
            comboBoxWaitlistSize.SelectedIndex = -1;
        }

        
        
            private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return to the Main Menu?", "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form2 mainMenu = new Form2();
                mainMenu.Show();
                this.Hide();
            }
            // If No is clicked, do nothing (stay on current page)
        }

    }
}
