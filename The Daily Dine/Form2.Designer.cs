namespace The_Daily_Dine
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            cashiers = new FlowLayoutPanel();
            pictureBox5 = new PictureBox();
            button3 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            customer = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            today_income = new Label();
            label7 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            Total_Income = new Label();
            label8 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            refreshButton = new Button();
            logoutButton = new Button();
            accountButton = new Button();
            pictureBox1 = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            flowLayoutPanel6 = new FlowLayoutPanel();
            pictureBox7 = new PictureBox();
            Button_3 = new Button();
            cashiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // cashiers
            // 
            cashiers.BackColor = Color.Teal;
            cashiers.Controls.Add(pictureBox5);
            cashiers.Controls.Add(button3);
            cashiers.Location = new Point(1044, 16);
            cashiers.Margin = new Padding(3, 4, 3, 4);
            cashiers.Name = "cashiers";
            cashiers.Size = new Size(208, 170);
            cashiers.TabIndex = 0;
            cashiers.Paint += cashiers_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 4);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(114, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 103);
            button3.Name = "button3";
            button3.Size = new Size(136, 29);
            button3.TabIndex = 7;
            button3.Text = "Review Form";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Teal;
            flowLayoutPanel2.Controls.Add(pictureBox4);
            flowLayoutPanel2.Controls.Add(customer);
            flowLayoutPanel2.Location = new Point(15, 16);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(207, 170);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer.ForeColor = Color.White;
            customer.Location = new Point(3, 96);
            customer.Name = "customer";
            customer.Size = new Size(164, 20);
            customer.TabIndex = 3;
            customer.Text = "Total of Customers";
            customer.Click += customer_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Teal;
            flowLayoutPanel3.Controls.Add(pictureBox3);
            flowLayoutPanel3.Controls.Add(today_income);
            flowLayoutPanel3.Controls.Add(label7);
            flowLayoutPanel3.Location = new Point(228, 16);
            flowLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(198, 170);
            flowLayoutPanel3.TabIndex = 2;
            flowLayoutPanel3.TabStop = true;
            flowLayoutPanel3.Paint += flowLayoutPanel3_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // today_income
            // 
            today_income.AutoSize = true;
            today_income.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            today_income.ForeColor = Color.White;
            today_income.Location = new Point(3, 96);
            today_income.Name = "today_income";
            today_income.Size = new Size(137, 20);
            today_income.TabIndex = 3;
            today_income.Text = "Today's Income";
            today_income.Click += today_income_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.BottomRight;
            label7.Location = new Point(3, 116);
            label7.Name = "label7";
            label7.Size = new Size(189, 40);
            label7.TabIndex = 4;
            label7.Text = "                                                                     $0";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Teal;
            flowLayoutPanel4.Controls.Add(pictureBox2);
            flowLayoutPanel4.Controls.Add(Total_Income);
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Location = new Point(432, 16);
            flowLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(199, 170);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Total_Income
            // 
            Total_Income.AutoSize = true;
            Total_Income.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Total_Income.ForeColor = Color.White;
            Total_Income.Location = new Point(3, 100);
            Total_Income.Name = "Total_Income";
            Total_Income.Size = new Size(115, 20);
            Total_Income.TabIndex = 3;
            Total_Income.Text = "Total Income";
            Total_Income.Click += Total_Income_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.ImageAlign = ContentAlignment.BottomRight;
            label8.Location = new Point(3, 120);
            label8.Name = "label8";
            label8.Size = new Size(193, 40);
            label8.TabIndex = 5;
            label8.Text = "                                                                     $0";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(refreshButton);
            flowLayoutPanel5.Controls.Add(logoutButton);
            flowLayoutPanel5.Controls.Add(accountButton);
            flowLayoutPanel5.Controls.Add(pictureBox1);
            flowLayoutPanel5.Location = new Point(14, 190);
            flowLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(1255, 526);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.Teal;
            refreshButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(3, 4);
            refreshButton.Margin = new Padding(3, 4, 3, 4);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(137, 54);
            refreshButton.TabIndex = 6;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Teal;
            logoutButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(146, 4);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(814, 54);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.DarkCyan;
            accountButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountButton.ForeColor = SystemColors.ButtonHighlight;
            accountButton.Location = new Point(965, 2);
            accountButton.Margin = new Padding(2);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(273, 55);
            accountButton.TabIndex = 7;
            accountButton.Text = "Account";
            accountButton.UseVisualStyleBackColor = false;
            accountButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 66);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1234, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkCyan;
            flowLayoutPanel1.Controls.Add(pictureBox6);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(634, 16);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(199, 170);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 4);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(150, 92);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 103);
            button1.Name = "button1";
            button1.Size = new Size(171, 29);
            button1.TabIndex = 6;
            button1.Text = "Table Reservations";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = Color.DarkCyan;
            flowLayoutPanel6.Controls.Add(pictureBox7);
            flowLayoutPanel6.Controls.Add(Button_3);
            flowLayoutPanel6.Location = new Point(839, 16);
            flowLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(199, 170);
            flowLayoutPanel6.TabIndex = 7;
            flowLayoutPanel6.Paint += flowLayoutPanel6_Paint;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 4);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(136, 92);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // Button_3
            // 
            Button_3.BackColor = Color.Teal;
            Button_3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_3.ForeColor = Color.White;
            Button_3.Location = new Point(3, 103);
            Button_3.Name = "Button_3";
            Button_3.Size = new Size(136, 29);
            Button_3.TabIndex = 6;
            Button_3.Text = "WaitList";
            Button_3.UseVisualStyleBackColor = false;
            Button_3.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 734);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(cashiers);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Minimized;
            Load += Form2_Load;
            cashiers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private FlowLayoutPanel cashiers;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        protected PictureBox pictureBox5;
        private Label customer;
        private Label today_income;
        private Label Total_Income;
        public Label label7;
        public Label label8;
        private Button refreshButton; // Added
        private Button logoutButton;
        private PictureBox pictureBox1;
        private Button accountButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox6;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel6;
        private PictureBox pictureBox7;
        private Button Button_3;
        private Button button3;
    }
}