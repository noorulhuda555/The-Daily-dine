// Polished Form6 Reservation Code
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace The_Daily_Dine
{
    public partial class Form6 : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";

        public Form6()
        {
            InitializeComponent();
            ApplyButtonHoverEffects();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations(string searchText = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id AS 'ID', customer_name AS 'Customer Name', table_number AS 'Table Number', capacity AS 'Capacity', reserved_at AS 'Reserved At' FROM table_reservations";

                    if (!string.IsNullOrWhiteSpace(searchText))
                        query += " WHERE customer_name LIKE @search OR table_number LIKE @search";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchText))
                            cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (dataGridView1.Columns.Contains("ID"))
                    dataGridView1.Columns["ID"].Visible = false;

                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text) ||
                string.IsNullOrWhiteSpace(textBoxTableNumber.Text) ||
                comboBoxCapacity.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields before adding!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsTableAlreadyReserved(textBoxTableNumber.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("This table is already reserved. Add to Waitlist?", "Already Reserved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Form7 waitlistForm = new Form7();
                    waitlistForm.PreFillWaitlist(textBoxCustomerName.Text.Trim(), Convert.ToInt32(comboBoxCapacity.SelectedItem));
                    waitlistForm.Show();
                }
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO table_reservations (customer_name, table_number, capacity) VALUES (@customerName, @tableNumber, @capacity)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerName", textBoxCustomerName.Text.Trim());
                        cmd.Parameters.AddWithValue("@tableNumber", textBoxTableNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@capacity", comboBoxCapacity.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding reservation: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBoxCustomerName.Text = dataGridView1.SelectedRows[0].Cells["Customer Name"].Value.ToString();
                textBoxTableNumber.Text = dataGridView1.SelectedRows[0].Cells["Table Number"].Value.ToString();
                comboBoxCapacity.Text = dataGridView1.SelectedRows[0].Cells["Capacity"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a reservation to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a reservation to save changes.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    string query = "UPDATE table_reservations SET customer_name = @customerName, table_number = @tableNumber, capacity = @capacity WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerName", textBoxCustomerName.Text.Trim());
                        cmd.Parameters.AddWithValue("@tableNumber", textBoxTableNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@capacity", comboBoxCapacity.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation updated!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving reservation: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a reservation to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                        string query = "DELETE FROM table_reservations WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Reservation deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservations();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting reservation: " + ex.Message);
                }
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            LoadReservations(textBoxSearch.Text.Trim());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Return to Main Menu?", "Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form2 mainMenu = new Form2();
                mainMenu.Show();
                this.Hide();
            }
        }

        private bool IsTableAlreadyReserved(string tableNumber)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM table_reservations WHERE table_number = @tableNumber";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void ClearInputs()
        {
            textBoxCustomerName.Clear();
            textBoxTableNumber.SelectedIndex = -1;

            comboBoxCapacity.SelectedIndex = -1;
        }

        private void ApplyButtonHoverEffects()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.LightBlue;
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.Teal;
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            // Nothing inside (Required for Designer)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Nothing inside (Required for Designer)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Nothing inside (Required for Designer)
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Nothing inside (Required for Designer)
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            // Nothing inside (Required for Designer)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: You can apply row highlight or styling here
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Nothing inside (Required for Designer)
        }

    }
}