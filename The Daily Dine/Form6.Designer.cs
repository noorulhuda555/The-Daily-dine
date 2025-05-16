namespace The_Daily_Dine
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            button1 = new Button();
            textBoxTableNumber = new ComboBox();
            textBoxCustomerName = new TextBox();
            label4 = new Label();
            comboBoxCapacity = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel8 = new Panel();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel7 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            Edit = new Button();
            ADD = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxTableNumber);
            panel1.Controls.Add(textBoxCustomerName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxCapacity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 643);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(12, 602);
            button1.Name = "button1";
            button1.Size = new Size(292, 29);
            button1.TabIndex = 7;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBoxTableNumber
            // 
            textBoxTableNumber.FormattingEnabled = true;
            textBoxTableNumber.Items.AddRange(new object[] { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10" });
            textBoxTableNumber.Location = new Point(12, 206);
            textBoxTableNumber.Name = "textBoxTableNumber";
            textBoxTableNumber.Size = new Size(255, 28);
            textBoxTableNumber.TabIndex = 8;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(12, 138);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(255, 27);
            textBoxCustomerName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 6;
            label4.Text = "Customer Name";
            label4.Click += label4_Click;
            // 
            // comboBoxCapacity
            // 
            comboBoxCapacity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCapacity.FlatStyle = FlatStyle.Popup;
            comboBoxCapacity.FormattingEnabled = true;
            comboBoxCapacity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxCapacity.Location = new Point(12, 269);
            comboBoxCapacity.Name = "comboBoxCapacity";
            comboBoxCapacity.Size = new Size(255, 28);
            comboBoxCapacity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 4;
            label3.Text = "Capacity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 2;
            label2.Text = "Table ID";
            label2.Click += label2_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(buttonSearch);
            panel8.Controls.Add(textBoxSearch);
            panel8.Location = new Point(0, 49);
            panel8.Name = "panel8";
            panel8.Size = new Size(319, 43);
            panel8.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(12, 7);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(63, 26);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(85, 9);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(219, 27);
            textBoxSearch.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 50);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 12);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 2;
            label1.Text = "Reserve your Table";
            label1.Click += label1_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(250, 46);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 125);
            panel6.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(322, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 643);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(817, 545);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Location = new Point(6, 56);
            panel7.Name = "panel7";
            panel7.Size = new Size(802, 36);
            panel7.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(Edit, 1, 0);
            tableLayoutPanel1.Controls.Add(ADD, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(802, 36);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkCyan;
            button4.Location = new Point(603, 3);
            button4.Name = "button4";
            button4.Size = new Size(196, 30);
            button4.TabIndex = 5;
            button4.Text = "&DELETE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkCyan;
            button3.Location = new Point(403, 3);
            button3.Name = "button3";
            button3.Size = new Size(194, 30);
            button3.TabIndex = 4;
            button3.Text = "&SAVE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.White;
            Edit.Dock = DockStyle.Fill;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.ForeColor = Color.DarkCyan;
            Edit.Location = new Point(203, 3);
            Edit.Name = "Edit";
            Edit.Size = new Size(194, 30);
            Edit.TabIndex = 3;
            Edit.Text = "&EDIT";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += button2_Click;
            // 
            // ADD
            // 
            ADD.BackColor = Color.White;
            ADD.Dock = DockStyle.Fill;
            ADD.FlatStyle = FlatStyle.Flat;
            ADD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADD.ForeColor = Color.DarkCyan;
            ADD.Location = new Point(3, 3);
            ADD.Name = "ADD";
            ADD.Size = new Size(194, 30);
            ADD.TabIndex = 2;
            ADD.Text = "&ADD";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(820, 50);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(550, 76);
            panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 5);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 643);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Panel panel2;
        public Panel panel3;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ADD;
        private Button button4;
        private Button button3;
        private Button Edit;
        private Label label1;
        private Panel panel8;
        private Label label2;
        private ComboBox comboBoxCapacity;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textBoxCustomerName;
        private Label label4;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private ComboBox textBoxTableNumber;
        private Button button1;
        private PictureBox pictureBox1;
    }
}