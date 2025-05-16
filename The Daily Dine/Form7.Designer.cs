
namespace The_Daily_Dine
{
    partial class Form7 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            panel5 = new Panel();
            ADD = new Button();
            TableNumberWaitList = new ComboBox();
            textBoxWaitlistName = new TextBox();
            label4 = new Label();
            comboBoxWaitlistSize = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel8 = new Panel();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            buttonMoveToReservation = new Button();
            buttonDeleteWaitlist = new Button();
            Edit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel7 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            dataGridViewWaitlist = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWaitlist).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(550, 76);
            panel5.TabIndex = 0;
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
            ADD.Click += ADD_Click;
            // 
            // TableNumberWaitList
            // 
            TableNumberWaitList.FormattingEnabled = true;
            TableNumberWaitList.Items.AddRange(new object[] { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10" });
            TableNumberWaitList.Location = new Point(12, 206);
            TableNumberWaitList.Name = "TableNumberWaitList";
            TableNumberWaitList.Size = new Size(255, 28);
            TableNumberWaitList.TabIndex = 8;
            TableNumberWaitList.SelectedIndexChanged += textBoxTableNumber_SelectedIndexChanged;
            // 
            // textBoxWaitlistName
            // 
            textBoxWaitlistName.Location = new Point(12, 138);
            textBoxWaitlistName.Name = "textBoxWaitlistName";
            textBoxWaitlistName.Size = new Size(255, 27);
            textBoxWaitlistName.TabIndex = 7;
            textBoxWaitlistName.TextChanged += textBoxWaitlistName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 6;
            label4.Text = "Customer Name";
            label4.Click += label4_Click;
            // 
            // comboBoxWaitlistSize
            // 
            comboBoxWaitlistSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWaitlistSize.FlatStyle = FlatStyle.Popup;
            comboBoxWaitlistSize.FormattingEnabled = true;
            comboBoxWaitlistSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxWaitlistSize.Location = new Point(12, 269);
            comboBoxWaitlistSize.Name = "comboBoxWaitlistSize";
            comboBoxWaitlistSize.Size = new Size(255, 28);
            comboBoxWaitlistSize.TabIndex = 5;
            comboBoxWaitlistSize.SelectedIndexChanged += comboBoxWaitlistSize_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Capacity";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
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
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(85, 9);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(219, 27);
            textBoxSearch.TabIndex = 7;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonMoveToReservation
            // 
            buttonMoveToReservation.BackColor = Color.White;
            buttonMoveToReservation.Dock = DockStyle.Fill;
            buttonMoveToReservation.FlatStyle = FlatStyle.Flat;
            buttonMoveToReservation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMoveToReservation.ForeColor = Color.DarkCyan;
            buttonMoveToReservation.Location = new Point(603, 3);
            buttonMoveToReservation.Name = "buttonMoveToReservation";
            buttonMoveToReservation.Size = new Size(196, 30);
            buttonMoveToReservation.TabIndex = 5;
            buttonMoveToReservation.Text = "&View Reservations";
            buttonMoveToReservation.UseVisualStyleBackColor = false;
            buttonMoveToReservation.Click += buttonMoveToReservation_Click;
            // 
            // buttonDeleteWaitlist
            // 
            buttonDeleteWaitlist.BackColor = Color.White;
            buttonDeleteWaitlist.Dock = DockStyle.Fill;
            buttonDeleteWaitlist.FlatStyle = FlatStyle.Flat;
            buttonDeleteWaitlist.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteWaitlist.ForeColor = Color.DarkCyan;
            buttonDeleteWaitlist.Location = new Point(403, 3);
            buttonDeleteWaitlist.Name = "buttonDeleteWaitlist";
            buttonDeleteWaitlist.Size = new Size(194, 30);
            buttonDeleteWaitlist.TabIndex = 4;
            buttonDeleteWaitlist.Text = "&DELETE";
            buttonDeleteWaitlist.UseVisualStyleBackColor = false;
            buttonDeleteWaitlist.Click += button3_Click;
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
            Edit.Click += Edit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(buttonMoveToReservation, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonDeleteWaitlist, 2, 0);
            tableLayoutPanel1.Controls.Add(Edit, 1, 0);
            tableLayoutPanel1.Controls.Add(ADD, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(802, 36);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Location = new Point(6, 56);
            panel7.Name = "panel7";
            panel7.Size = new Size(802, 36);
            panel7.TabIndex = 2;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 12);
            label1.Name = "label1";
            label1.Size = new Size(245, 31);
            label1.TabIndex = 2;
            label1.Text = "Waitlist Management";
            // 
            // panel6
            // 
            panel6.Location = new Point(250, 46);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 125);
            panel6.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(820, 50);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridViewWaitlist);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(322, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 544);
            panel2.TabIndex = 3;
            // 
            // dataGridViewWaitlist
            // 
            dataGridViewWaitlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWaitlist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWaitlist.BackgroundColor = Color.White;
            dataGridViewWaitlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWaitlist.Location = new Point(0, 95);
            dataGridViewWaitlist.Name = "dataGridViewWaitlist";
            dataGridViewWaitlist.RowHeadersWidth = 51;
            dataGridViewWaitlist.Size = new Size(817, 449);
            dataGridViewWaitlist.TabIndex = 6;
            dataGridViewWaitlist.CellContentClick += dataGridViewWaitlist_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TableNumberWaitList);
            panel1.Controls.Add(textBoxWaitlistName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxWaitlistSize);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 544);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(12, 503);
            button1.Name = "button1";
            button1.Size = new Size(292, 29);
            button1.TabIndex = 9;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 544);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWaitlist).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Panel panel5;
        private Button ADD;
        private ComboBox TableNumberWaitList;
        private TextBox textBoxWaitlistName;
        private Label label4;
        private ComboBox comboBoxWaitlistSize;
        private Label label3;
        private Label label2;
        private Panel panel8;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Button buttonMoveToReservation;
        private Button buttonDeleteWaitlist;
        private Button Edit;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel7;
        public Panel panel3;
        private Label label1;
        private Panel panel6;
        private Panel panel4;
        public Panel panel2;
        private DataGridView dataGridViewWaitlist;
        public Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}