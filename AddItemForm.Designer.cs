namespace Shopping_Mart_Application
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            pictureBox = new PictureBox();
            Addpanel = new Panel();
            InsertBtn = new Button();
            textBoxDiscount = new TextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            labelId = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            Addpanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(12, 20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(620, 79);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 17;
            pictureBox.TabStop = false;
            // 
            // Addpanel
            // 
            Addpanel.BackColor = Color.LightGray;
            Addpanel.BorderStyle = BorderStyle.Fixed3D;
            Addpanel.Controls.Add(InsertBtn);
            Addpanel.Controls.Add(textBoxDiscount);
            Addpanel.Controls.Add(textBoxPrice);
            Addpanel.Controls.Add(textBoxName);
            Addpanel.Controls.Add(label3);
            Addpanel.Controls.Add(label2);
            Addpanel.Controls.Add(labelId);
            Addpanel.Controls.Add(label1);
            Addpanel.Location = new Point(139, 114);
            Addpanel.Name = "Addpanel";
            Addpanel.Size = new Size(374, 281);
            Addpanel.TabIndex = 18;
            // 
            // InsertBtn
            // 
            InsertBtn.Anchor = AnchorStyles.None;
            InsertBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsertBtn.Location = new Point(118, 200);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(78, 32);
            InsertBtn.TabIndex = 3;
            InsertBtn.Text = "Insert";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Anchor = AnchorStyles.None;
            textBoxDiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDiscount.Location = new Point(118, 149);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(215, 25);
            textBoxDiscount.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.None;
            textBoxPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPrice.Location = new Point(118, 103);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(215, 25);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(118, 56);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 25);
            textBoxName.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 157);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 3;
            label3.Text = "Discount";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // labelId
            // 
            labelId.Anchor = AnchorStyles.None;
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.Location = new Point(33, 64);
            labelId.Name = "labelId";
            labelId.Size = new Size(44, 17);
            labelId.TabIndex = 1;
            labelId.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Item";
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 451);
            Controls.Add(Addpanel);
            Controls.Add(pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddItemForm";
            FormClosed += AddItemForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            Addpanel.ResumeLayout(false);
            Addpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Panel Addpanel;
        private Label label1;
        private Label labelId;
        private TextBox textBoxDiscount;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Button InsertBtn;
    }
}