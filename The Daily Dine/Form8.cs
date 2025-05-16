using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Daily_Dine
{
    public partial class Form8 : Form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;";
        private int selectedReviewId = -1; // For editing/deleting

        public Form8()
        {
            InitializeComponent();
            LoadReviews();
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCustomerName.Text.Length < 3)
            {
                textBoxCustomerName.BackColor = Color.MistyRose; // Light red if too short
            }
            else
            {
                textBoxCustomerName.BackColor = Color.White; // Normal
            }
        }

        private void comboBoxRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRating.SelectedItem != null)
            {
                string selectedRating = comboBoxRating.SelectedItem.ToString();
                labelTitle.Text = "⭐".PadRight(int.Parse(selectedRating[0].ToString()), '⭐');
            }
        }

        private void textBoxFeedback_TextChanged(object sender, EventArgs e)
        {
            this.Text = $"Feedback ({textBoxFeedback.Text.Length}/500 characters)";
            if (textBoxFeedback.Text.Length > 500)
            {
                MessageBox.Show("Feedback too long! Maximum 500 characters.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFeedback.Text = textBoxFeedback.Text.Substring(0, 500); // Limit to 500
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form2 dashboard = new Form2();
            dashboard.Show();
            this.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text) || comboBoxRating.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxFeedback.Text))
            {
                MessageBox.Show("Please fill all the fields properly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    if (selectedReviewId == -1)
                    {
                        // Insert new review
                        string insertQuery = "INSERT INTO reviews (customer_name, rating, feedback, review_date) VALUES (@name, @rating, @feedback, NOW())";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", textBoxCustomerName.Text.Trim());
                            cmd.Parameters.AddWithValue("@rating", comboBoxRating.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@feedback", textBoxFeedback.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Thank you for your review!", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Update existing review
                        string updateQuery = "UPDATE reviews SET customer_name = @name, rating = @rating, feedback = @feedback WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", textBoxCustomerName.Text.Trim());
                            cmd.Parameters.AddWithValue("@rating", comboBoxRating.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@feedback", textBoxFeedback.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", selectedReviewId);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Review updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedReviewId = -1; // Reset after update
                    }
                }

                ClearFields();
                LoadReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting review: " + ex.Message);
            }
        }

        private void dataGridViewReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReviews.Rows[e.RowIndex];
                string customerName = row.Cells["Customer"].Value.ToString();
                string rating = row.Cells["Rating"].Value.ToString();
                string feedback = row.Cells["Feedback"].Value.ToString();

                textBoxCustomerName.Text = customerName;
                comboBoxRating.SelectedItem = rating;
                textBoxFeedback.Text = feedback;

                selectedReviewId = GetReviewId(customerName, feedback);
                if (selectedReviewId != -1)
                {
                    DialogResult result = MessageBox.Show("Do you want to edit or delete this review?", "Choose Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        // Delete
                        DeleteReview(selectedReviewId);
                        selectedReviewId = -1;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        ClearFields();
                    }
                }
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {
            // Not needed
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
            // Optional to paint background
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Optional
        }

        private void LoadReviews()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string selectQuery = "SELECT customer_name AS 'Customer', rating AS 'Rating', feedback AS 'Feedback', review_date AS 'Date' FROM reviews";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewReviews.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textBoxCustomerName.Clear();
            comboBoxRating.SelectedIndex = -1;
            textBoxFeedback.Clear();
            this.Text = "Review Your Experience"; // Reset title
        }

        private int GetReviewId(string customerName, string feedback)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id FROM reviews WHERE customer_name = @name AND feedback = @feedback ORDER BY review_date DESC LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", customerName);
                        cmd.Parameters.AddWithValue("@feedback", feedback);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding review ID: " + ex.Message);
            }

            return -1;
        }

        private void DeleteReview(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM reviews WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Review deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting review: " + ex.Message);
            }
        }
    }
}
