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
            label1 = new Label();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            customer = new Label();
            label6 = new Label();
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
            pictureBox1 = new PictureBox();
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
            SuspendLayout();
            // 
            // cashiers
            // 
            cashiers.BackColor = Color.Teal;
            cashiers.Controls.Add(pictureBox5);
            cashiers.Controls.Add(label1);
            cashiers.Controls.Add(label5);
            cashiers.Location = new Point(12, 12);
            cashiers.Name = "cashiers";
            cashiers.Size = new Size(240, 117);
            cashiers.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            label1.Text = "Total of Cashiers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.BottomRight;
            label5.Location = new Point(3, 72);
            label5.Name = "label5";
            label5.Size = new Size(222, 15);
            label5.TabIndex = 3;
            label5.Text = "                                                                     0";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Teal;
            flowLayoutPanel2.Controls.Add(pictureBox4);
            flowLayoutPanel2.Controls.Add(customer);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Location = new Point(258, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(280, 117);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 66);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer.ForeColor = Color.White;
            customer.Location = new Point(109, 0);
            customer.Name = "customer";
            customer.Size = new Size(129, 15);
            customer.TabIndex = 3;
            customer.Text = "Total of Customers";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.BottomRight;
            label6.Location = new Point(3, 72);
            label6.Name = "label6";
            label6.Size = new Size(222, 15);
            label6.TabIndex = 4;
            label6.Text = "                                                                     0";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Teal;
            flowLayoutPanel3.Controls.Add(pictureBox3);
            flowLayoutPanel3.Controls.Add(today_income);
            flowLayoutPanel3.Controls.Add(label7);
            flowLayoutPanel3.Location = new Point(544, 12);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(276, 117);
            flowLayoutPanel3.TabIndex = 2;
            flowLayoutPanel3.TabStop = true;
            flowLayoutPanel3.Paint += flowLayoutPanel3_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // today_income
            // 
            today_income.AutoSize = true;
            today_income.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            today_income.ForeColor = Color.White;
            today_income.Location = new Point(109, 0);
            today_income.Name = "today_income";
            today_income.Size = new Size(107, 15);
            today_income.TabIndex = 3;
            today_income.Text = "Today's Income";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.BottomRight;
            label7.Location = new Point(3, 72);
            label7.Name = "label7";
            label7.Size = new Size(230, 15);
            label7.TabIndex = 4;
            label7.Text = "                                                                     $0";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Teal;
            flowLayoutPanel4.Controls.Add(pictureBox2);
            flowLayoutPanel4.Controls.Add(Total_Income);
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Location = new Point(826, 12);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(284, 117);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Total_Income
            // 
            Total_Income.AutoSize = true;
            Total_Income.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Total_Income.ForeColor = Color.White;
            Total_Income.Location = new Point(109, 0);
            Total_Income.Name = "Total_Income";
            Total_Income.Size = new Size(91, 15);
            Total_Income.TabIndex = 3;
            Total_Income.Text = "Total Income";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.ImageAlign = ContentAlignment.BottomRight;
            label8.Location = new Point(3, 72);
            label8.Name = "label8";
            label8.Size = new Size(230, 15);
            label8.TabIndex = 5;
            label8.Text = "                                                                     $0";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(refreshButton);
            flowLayoutPanel5.Controls.Add(logoutButton);
            flowLayoutPanel5.Controls.Add(pictureBox1);
            flowLayoutPanel5.Location = new Point(12, 143);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(1098, 395);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.Teal;
            refreshButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(3, 3);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(120, 40);
            refreshButton.TabIndex = 6;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Teal;
            logoutButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(129, 3);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(954, 40);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1080, 376);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 550);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(cashiers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            cashiers.ResumeLayout(false);
            cashiers.PerformLayout();
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
            ResumeLayout(false);
        }
        #endregion

        private FlowLayoutPanel cashiers;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        protected PictureBox pictureBox5;
        private Label customer;
        private Label today_income;
        private Label Total_Income;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        private Button logoutButton; // Added
        private Button refreshButton; // Added
    }
}