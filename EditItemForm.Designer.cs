namespace Shopping_Mart_Application
{
    partial class EditItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemForm));
            pictureBox = new PictureBox();
            panelUpdate = new Panel();
            buttonDelete = new Button();
            UpdateBtn = new Button();
            textBoxDiscount = new TextBox();
            textBoxPrice = new TextBox();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            IDlabel = new Label();
            labelId = new Label();
            dataGridView = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(620, 79);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 19;
            pictureBox.TabStop = false;
            // 
            // panelUpdate
            // 
            panelUpdate.Anchor = AnchorStyles.None;
            panelUpdate.BackColor = Color.LightGray;
            panelUpdate.BorderStyle = BorderStyle.Fixed3D;
            panelUpdate.Controls.Add(buttonDelete);
            panelUpdate.Controls.Add(UpdateBtn);
            panelUpdate.Controls.Add(textBoxDiscount);
            panelUpdate.Controls.Add(textBoxPrice);
            panelUpdate.Controls.Add(textBoxId);
            panelUpdate.Controls.Add(textBoxName);
            panelUpdate.Controls.Add(label3);
            panelUpdate.Controls.Add(label2);
            panelUpdate.Controls.Add(IDlabel);
            panelUpdate.Controls.Add(labelId);
            panelUpdate.Controls.Add(label4);
            panelUpdate.Location = new Point(120, 97);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(391, 270);
            panelUpdate.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(251, 228);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(92, 32);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.None;
            UpdateBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(128, 228);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 32);
            UpdateBtn.TabIndex = 4;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Anchor = AnchorStyles.None;
            textBoxDiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDiscount.Location = new Point(128, 177);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(215, 25);
            textBoxDiscount.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.None;
            textBoxPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPrice.Location = new Point(128, 131);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(215, 25);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.None;
            textBoxId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxId.Location = new Point(128, 36);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(215, 25);
            textBoxId.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(128, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 25);
            textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 185);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 0;
            label3.Text = "Discount";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 139);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 0;
            label2.Text = "Price";
            // 
            // IDlabel
            // 
            IDlabel.Anchor = AnchorStyles.None;
            IDlabel.AutoSize = true;
            IDlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDlabel.Location = new Point(43, 44);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(20, 17);
            IDlabel.TabIndex = 0;
            IDlabel.Text = "Id";
            // 
            // labelId
            // 
            labelId.Anchor = AnchorStyles.None;
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.Location = new Point(43, 92);
            labelId.Name = "labelId";
            labelId.Size = new Size(44, 17);
            labelId.TabIndex = 0;
            labelId.Text = "Name";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(87, 373);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(456, 123);
            dataGridView.TabIndex = 20;
            dataGridView.MouseDoubleClick += dataGridView_MouseDoubleClick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, -6);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 0;
            label4.Text = "Edit Item";
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 524);
            Controls.Add(dataGridView);
            Controls.Add(panelUpdate);
            Controls.Add(pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditItemForm";
            FormClosed += EditItemForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Panel panelUpdate;
        private Button UpdateBtn;
        private TextBox textBoxDiscount;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label labelId;
        private Button buttonDelete;
        private TextBox textBoxId;
        private Label IDlabel;
        private DataGridView dataGridView;
        private Label label4;
    }
}