namespace The_Daily_Dine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            register_btn = new Button();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label8 = new Label();
            register_showpass = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            register_username = new TextBox();
            textregister_password = new TextBox();
            register_cpassword = new TextBox();
            register_btn2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_btn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Teal;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 124);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.Teal;
            register_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(105, 384);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(135, 46);
            register_btn.TabIndex = 7;
            register_btn.Text = "SIGN IN";
            register_btn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 8);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 354);
            label3.Name = "label3";
            label3.Size = new Size(220, 18);
            label3.TabIndex = 3;
            label3.Text = "Already Have an Account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 231);
            label4.Name = "label4";
            label4.Size = new Size(329, 24);
            label4.TabIndex = 2;
            label4.Text = "Cafe Shop Management System";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(522, 69);
            label5.Name = "label5";
            label5.Size = new Size(119, 24);
            label5.TabIndex = 4;
            label5.Text = "REGISTER";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(534, 93);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 7;
            // 
            // register_showpass
            // 
            register_showpass.AutoSize = true;
            register_showpass.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showpass.Location = new Point(427, 328);
            register_showpass.Name = "register_showpass";
            register_showpass.Size = new Size(147, 21);
            register_showpass.TabIndex = 8;
            register_showpass.Text = "Show Password ";
            register_showpass.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(427, 278);
            label9.Name = "label9";
            label9.Size = new Size(157, 18);
            label9.TabIndex = 9;
            label9.Text = "Confirm Password ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(427, 216);
            label10.Name = "label10";
            label10.Size = new Size(91, 18);
            label10.TabIndex = 10;
            label10.Text = "Password ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(426, 154);
            label11.Name = "label11";
            label11.Size = new Size(90, 18);
            label11.TabIndex = 11;
            label11.Text = "Username";
            // 
            // register_username
            // 
            register_username.Location = new Point(427, 175);
            register_username.Name = "register_username";
            register_username.Size = new Size(303, 23);
            register_username.TabIndex = 12;
            // textregister_password
            // 
            textregister_password.Location = new Point(427, 237);
            textregister_password.Name = "textregister_password";
            textregister_password.Size = new Size(303, 23);
            textregister_password.TabIndex = 13;
            // 
            // register_cpassword
            // 
            register_cpassword.Location = new Point(427, 299);
            register_cpassword.Name = "register_cpassword";
            register_cpassword.Size = new Size(303, 23);
            register_cpassword.TabIndex = 14;
            // 
            // register_btn2
            // 
            register_btn2.BackColor = Color.Teal;
            register_btn2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn2.ForeColor = Color.White;
            register_btn2.Location = new Point(426, 371);
            register_btn2.Name = "register_btn2";
            register_btn2.Size = new Size(135, 46);
            register_btn2.TabIndex = 15;
            register_btn2.Text = "SIGN UP";
            register_btn2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(register_btn2);
            Controls.Add(register_cpassword);
            Controls.Add(textregister_password);
            Controls.Add(register_username);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(register_showpass);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label8;
        private Button register_btn;
        private PictureBox pictureBox1;
        private CheckBox register_showpass;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox register_username;
        private TextBox textregister_password;
        private TextBox register_cpassword;
        private Button register_btn2;
    }
}
