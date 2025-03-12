//libraries
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace The_Daily_Dine //big class 
{
    public partial class Form3 : Form //partial class
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=123456;";

        //initilize form3 login
        public Form3()
        {
            InitializeComponent();
            login_password.PasswordChar = '*';
            WireUpEvents(); //event handling 
        }

        private void WireUpEvents()
        {
            login_btn2.Click += new EventHandler(LoginBtn2Click); //trigger  login when button is pressed 
            login_showpass.CheckedChanged += new EventHandler(LoginShowpassCheckedChanged); //show password 
            login_btn.Click += new EventHandler(LoginBtnClick); //go to registeration page if not signed in before
        }

        private void LoginBtn2Click(object sender, EventArgs e) 
        {
            //retrieve and trim inputs
            string username = login_username.Text.Trim(); 
            string password = login_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateUsername(username))
                return; //exit 

            if (!ValidatePassword(password))
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    //run query to check username exits in db
                    //input validation
                    string usernameQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    MySqlCommand usernameCmd = new MySqlCommand(usernameQuery, conn);
                    usernameCmd.Parameters.AddWithValue("@username", username); //add parameters @ wala db mai hai, dusra is input
                    long usernameCount = (long)usernameCmd.ExecuteScalar(); //execute query and return count of username 

                    if (usernameCount == 0)
                    {
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //if user name found 
                    string passwordQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                    MySqlCommand passwordCmd = new MySqlCommand(passwordQuery, conn);
                    passwordCmd.Parameters.AddWithValue("@username", username);
                    passwordCmd.Parameters.AddWithValue("@password", password);
                    long passwordCount = (long)passwordCmd.ExecuteScalar();

                    if (passwordCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        Form2 dashboardForm = new Form2();
                        dashboardForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //handle mysql exceptions 
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message + " (Error Code: " + ex.Number + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginShowpassCheckedChanged(object sender, EventArgs e) //toggle password visibilty
        {
            if (login_showpass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void LoginBtnClick(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1(); //go to registeration 
            registerForm.Show();
            Hide();
        }

        private void ClearFields() //helper 
        {
            login_username.Text = string.Empty;
            login_password.Text = string.Empty;
            login_showpass.Checked = false;
        }

        private static bool ValidateUsername(string username)
        {
            if (username.Length < 3 || username.Length > 50)
            {
                MessageBox.Show("Username must be between 3 and 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_-]+$"))
            {
                MessageBox.Show("Username can only contain letters, numbers, underscores, or hyphens.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]+$"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character (e.g., !@#$%^&*).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}