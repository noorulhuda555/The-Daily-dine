using System; //console and system library input output
using System.Windows.Forms; //textboxes, windows forms
using MySql.Data.MySqlClient; //sql interaction
using System.Text.RegularExpressions; //input validation

namespace The_Daily_Dine //scope groups classes
{
    public partial class Form1 : Form //form1 class gui form
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=daily_dine_db;Uid=root;Pwd=Ridazubair99;"; //db string connection

        public Form1() //constuctor
        {
            InitializeComponent(); 
            textregister_password.PasswordChar = '*'; //hide passcode
            register_cpassword.PasswordChar = '*'; 

            register_btn2.Click += new EventHandler(RegisterBtn2Click); //button 
            register_btn.Click += new EventHandler(RegisterBtnClick); 
            register_showpass.CheckedChanged += new EventHandler(RegisterShowpassCheckedChanged); //checkbox toggle
        }

        private void RegisterBtn2Click(object sender, EventArgs e) //registeration button clicked 
        {
            //retrieve info and trim input
            string username = register_username.Text.Trim(); 
            string password = textregister_password.Text.Trim();
            string confirmPassword = register_cpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword)) //if any feild is empty to error dega 
            {   
                //error msg
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword) 
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (!ValidateUsername(username)) //validates username and if its wrong exit
                return;

            if (!ValidatePassword(password))
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString)) //new connection string for validation
                {
                    conn.Open();
                    //username validation query
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username"; //check username exits 
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn); 
                    checkCmd.Parameters.AddWithValue("@username", username); //safety run query
                    long count = (long)checkCmd.ExecuteScalar(); //if any matching username exits 
                    if (count > 0) //if username exits 
                    {   
                        //display error 
                        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //insert query
                    string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)"; 
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = insertCmd.ExecuteNonQuery(); //if its added 
                    if (rowsAffected > 0) //koi cheez add hui hai 
                    {   
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        Form3 loginForm = new Form3(); //login par jao
                        loginForm.Show(); //new login form show
                        Hide(); //hides current form
                    }
                }
            }
            //check mysql exceptions/errors 
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message + " (Error Code: " + ex.Number + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterBtnClick(object sender, EventArgs e) //button 1 is login button 
        {
            Form3 loginForm = new Form3();
            loginForm.Show();
            Hide();
        }

        private void RegisterShowpassCheckedChanged(object sender, EventArgs e) //toggle passcode visibilty
        {
            if (register_showpass.Checked) 
            {
                textregister_password.PasswordChar = '\0'; //dont hide password
                register_cpassword.PasswordChar = '\0';
            }
            else
            {
                textregister_password.PasswordChar = '*';
                register_cpassword.PasswordChar = '*';
            }
        }

        private void ClearFields() //helper function 
        {
            register_username.Text = "";
            textregister_password.Text = "";
            register_cpassword.Text = "";
            register_showpass.Checked = false;
        }

        private void Label4Click(object sender, EventArgs e) { }
        private void Label8Click(object sender, EventArgs e) { }

        private static bool ValidateUsername(string username) //helper function for username validation
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

        private static bool ValidatePassword(string password) //helper function for password validation
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