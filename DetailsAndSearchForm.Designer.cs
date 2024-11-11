namespace Shopping_Mart_Application
{
    partial class DetailsAndSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsAndSearchForm));
            pictureBox = new PictureBox();
            dataGridView = new DataGridView();
            label4 = new Label();
            textBoxSearch = new TextBox();
            SearchBtn = new Button();
            labelfialCost = new Label();
            textBoxFinalCost = new TextBox();
            label1stdate = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2ndDate = new Label();
            dateTimePicker2 = new DateTimePicker();
            buttonDate = new Button();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(4, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(620, 79);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 20;
            pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 226);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(602, 236);
            dataGridView.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 0;
            label4.Text = "Search  By Invoice";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.None;
            textBoxSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(12, 122);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "       Type Here InvoiceId";
            textBoxSearch.Size = new Size(194, 25);
            textBoxSearch.TabIndex = 0;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.None;
            SearchBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(12, 153);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(194, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // labelfialCost
            // 
            labelfialCost.Anchor = AnchorStyles.None;
            labelfialCost.AutoSize = true;
            labelfialCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelfialCost.Location = new Point(12, 193);
            labelfialCost.Name = "labelfialCost";
            labelfialCost.Size = new Size(69, 17);
            labelfialCost.TabIndex = 0;
            labelfialCost.Text = "Final Cost";
            // 
            // textBoxFinalCost
            // 
            textBoxFinalCost.Anchor = AnchorStyles.None;
            textBoxFinalCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFinalCost.Location = new Point(87, 189);
            textBoxFinalCost.Name = "textBoxFinalCost";
            textBoxFinalCost.ReadOnly = true;
            textBoxFinalCost.Size = new Size(119, 25);
            textBoxFinalCost.TabIndex = 2;
            // 
            // label1stdate
            // 
            label1stdate.Anchor = AnchorStyles.None;
            label1stdate.AutoSize = true;
            label1stdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1stdate.Location = new Point(319, 96);
            label1stdate.Name = "label1stdate";
            label1stdate.Size = new Size(103, 17);
            label1stdate.TabIndex = 21;
            label1stdate.Text = "First Date Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy/ hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(317, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2ndDate
            // 
            label2ndDate.Anchor = AnchorStyles.None;
            label2ndDate.AutoSize = true;
            label2ndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2ndDate.Location = new Point(319, 143);
            label2ndDate.Name = "label2ndDate";
            label2ndDate.Size = new Size(120, 17);
            label2ndDate.TabIndex = 21;
            label2ndDate.Text = "Second Date Time";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy/ hh:mm:ss tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(319, 163);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(240, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // buttonDate
            // 
            buttonDate.Anchor = AnchorStyles.None;
            buttonDate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDate.Location = new Point(319, 188);
            buttonDate.Name = "buttonDate";
            buttonDate.Size = new Size(151, 32);
            buttonDate.TabIndex = 4;
            buttonDate.Text = "Search with date";
            buttonDate.UseVisualStyleBackColor = true;
            buttonDate.Click += buttonDate_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.None;
            buttonReset.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(473, 188);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(86, 32);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // DetailsAndSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 462);
            Controls.Add(buttonReset);
            Controls.Add(buttonDate);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2ndDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1stdate);
            Controls.Add(textBoxFinalCost);
            Controls.Add(labelfialCost);
            Controls.Add(SearchBtn);
            Controls.Add(textBoxSearch);
            Controls.Add(label4);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DetailsAndSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details and Search form";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private DataGridView dataGridView;
        private Label label4;
        private TextBox textBoxSearch;
        private Button SearchBtn;
        private Label labelfialCost;
        private TextBox textBoxFinalCost;
        private Label label1stdate;
        private DateTimePicker dateTimePicker1;
        private Label label2ndDate;
        private DateTimePicker dateTimePicker2;
        private Button buttonDate;
        private Button buttonReset;
    }
}