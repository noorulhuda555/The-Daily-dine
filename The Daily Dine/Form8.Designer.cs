namespace The_Daily_Dine
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            panelHeader = new Panel();
            labelTitle = new Label();
            panelLeft = new Panel();
            labelName = new Label();
            textBoxCustomerName = new TextBox();
            labelRating = new Label();
            comboBoxRating = new ComboBox();
            labelFeedback = new Label();
            textBoxFeedback = new TextBox();
            buttonSubmit = new Button();
            buttonBack = new Button();
            dataGridViewReviews = new DataGridView();
            panelRight = new Panel();
            pictureBox1 = new PictureBox();
            panelHeader.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 60);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(300, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(286, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Leave Your Review!";
            labelTitle.Click += labelTitle_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.DarkCyan;
            panelLeft.Controls.Add(labelName);
            panelLeft.Controls.Add(textBoxCustomerName);
            panelLeft.Controls.Add(labelRating);
            panelLeft.Controls.Add(comboBoxRating);
            panelLeft.Controls.Add(labelFeedback);
            panelLeft.Controls.Add(textBoxFeedback);
            panelLeft.Controls.Add(buttonSubmit);
            panelLeft.Controls.Add(buttonBack);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 60);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 540);
            panelLeft.TabIndex = 1;
            panelLeft.Paint += panelLeft_Paint;
            // 
            // labelName
            // 
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(20, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(150, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Customer Name:";
            labelName.Click += labelName_Click;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(20, 60);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(250, 27);
            textBoxCustomerName.TabIndex = 1;
            textBoxCustomerName.TextChanged += textBoxCustomerName_TextChanged;
            // 
            // labelRating
            // 
            labelRating.ForeColor = Color.White;
            labelRating.Location = new Point(20, 100);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(100, 25);
            labelRating.TabIndex = 2;
            labelRating.Text = "Rating:";
            // 
            // comboBoxRating
            // 
            comboBoxRating.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxRating.Location = new Point(20, 130);
            comboBoxRating.Name = "comboBoxRating";
            comboBoxRating.Size = new Size(250, 28);
            comboBoxRating.TabIndex = 3;
            comboBoxRating.SelectedIndexChanged += comboBoxRating_SelectedIndexChanged;
            // 
            // labelFeedback
            // 
            labelFeedback.ForeColor = Color.White;
            labelFeedback.Location = new Point(20, 170);
            labelFeedback.Name = "labelFeedback";
            labelFeedback.Size = new Size(100, 25);
            labelFeedback.TabIndex = 4;
            labelFeedback.Text = "Feedback:";
            // 
            // textBoxFeedback
            // 
            textBoxFeedback.Location = new Point(20, 200);
            textBoxFeedback.Multiline = true;
            textBoxFeedback.Name = "textBoxFeedback";
            textBoxFeedback.Size = new Size(250, 150);
            textBoxFeedback.TabIndex = 5;
            textBoxFeedback.TextChanged += textBoxFeedback_TextChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.White;
            buttonSubmit.ForeColor = Color.DarkCyan;
            buttonSubmit.Location = new Point(20, 370);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(115, 35);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.White;
            buttonBack.ForeColor = Color.DarkCyan;
            buttonBack.Location = new Point(155, 370);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(115, 35);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridViewReviews
            // 
            dataGridViewReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReviews.BackgroundColor = Color.White;
            dataGridViewReviews.ColumnHeadersHeight = 29;
            dataGridViewReviews.Dock = DockStyle.Fill;
            dataGridViewReviews.Location = new Point(0, 0);
            dataGridViewReviews.Name = "dataGridViewReviews";
            dataGridViewReviews.RowHeadersWidth = 51;
            dataGridViewReviews.Size = new Size(600, 540);
            dataGridViewReviews.TabIndex = 0;
            dataGridViewReviews.CellContentClick += dataGridViewReviews_CellContentClick;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(dataGridViewReviews);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(300, 60);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(600, 540);
            panelRight.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            ClientSize = new Size(900, 600);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelHeader);
            Name = "Form8";
            Text = "Review Your Experience";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).EndInit();
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelLeft;
        private Label labelName;
        private TextBox textBoxCustomerName;
        private Label labelRating;
        private ComboBox comboBoxRating;
        private Label labelFeedback;
        private TextBox textBoxFeedback;
        private Button buttonSubmit;
        private Button buttonBack;
        private Panel panelRight;
        private DataGridView dataGridViewReviews;
        private PictureBox pictureBox1;
    }
}
