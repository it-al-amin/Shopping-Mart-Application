namespace Shopping_Mart_Application
{
    partial class RoyalMartForm
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
            DataGridView dataGridView;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoyalMartForm));
            textBoxPaid = new TextBox();
            label8 = new Label();
            textBoxQuantity = new TextBox();
            label7 = new Label();
            label1 = new Label();
            textBoxInvoice = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label14 = new Label();
            textBoxChange = new TextBox();
            textBoxSubtotal = new TextBox();
            textBoxUser = new TextBox();
            label3 = new Label();
            comboBoxItem = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            textBoxDiscount = new TextBox();
            buttonReset = new Button();
            buttonAdd = new Button();
            label5 = new Label();
            textBoxUnitPrice = new TextBox();
            label4 = new Label();
            textBoxTax = new TextBox();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox = new PictureBox();
            textBoxTotal = new TextBox();
            textBoxFinalCost = new TextBox();
            clear_Btn = new Button();
            insertBtn = new Button();
            PreviewqBtn = new Button();
            printBtn = new Button();
            printPreviewDialog = new PrintPreviewDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Location = new Point(22, 434);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(600, 135);
            dataGridView.TabIndex = 14;
            dataGridView.Visible = false;
            // 
            // textBoxPaid
            // 
            textBoxPaid.Anchor = AnchorStyles.None;
            textBoxPaid.Location = new Point(444, 279);
            textBoxPaid.Name = "textBoxPaid";
            textBoxPaid.Size = new Size(178, 25);
            textBoxPaid.TabIndex = 8;
            textBoxPaid.TextChanged += textBoxPaid_TextChanged;
            textBoxPaid.KeyPress += textBoxPaid_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(444, 247);
            label8.Name = "label8";
            label8.Size = new Size(89, 17);
            label8.TabIndex = 10;
            label8.Text = "Amount Paid";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Anchor = AnchorStyles.None;
            textBoxQuantity.Enabled = false;
            textBoxQuantity.Location = new Point(229, 203);
            textBoxQuantity.MaxLength = 3;
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(178, 25);
            textBoxQuantity.TabIndex = 3;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(229, 172);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 5;
            label7.Text = "Quantity";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(22, 101);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "Invoice No";
            // 
            // textBoxInvoice
            // 
            textBoxInvoice.Anchor = AnchorStyles.None;
            textBoxInvoice.ImeMode = ImeMode.Off;
            textBoxInvoice.Location = new Point(22, 134);
            textBoxInvoice.Name = "textBoxInvoice";
            textBoxInvoice.ReadOnly = true;
            textBoxInvoice.Size = new Size(178, 25);
            textBoxInvoice.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(22, 172);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(229, 247);
            label9.Name = "label9";
            label9.Size = new Size(66, 17);
            label9.TabIndex = 6;
            label9.Text = "Sub Total";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(444, 320);
            label14.Name = "label14";
            label14.Size = new Size(54, 17);
            label14.TabIndex = 11;
            label14.Text = "Change";
            // 
            // textBoxChange
            // 
            textBoxChange.Anchor = AnchorStyles.None;
            textBoxChange.ImeMode = ImeMode.Off;
            textBoxChange.Location = new Point(443, 353);
            textBoxChange.Name = "textBoxChange";
            textBoxChange.ReadOnly = true;
            textBoxChange.Size = new Size(178, 25);
            textBoxChange.TabIndex = 9;
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Anchor = AnchorStyles.None;
            textBoxSubtotal.ImeMode = ImeMode.Off;
            textBoxSubtotal.Location = new Point(229, 279);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.ReadOnly = true;
            textBoxSubtotal.Size = new Size(178, 25);
            textBoxSubtotal.TabIndex = 4;
            textBoxSubtotal.TextChanged += textBoxSubtotal_TextChanged;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.None;
            textBoxUser.ImeMode = ImeMode.Off;
            textBoxUser.Location = new Point(22, 203);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.ReadOnly = true;
            textBoxUser.Size = new Size(178, 25);
            textBoxUser.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(22, 246);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 2;
            label3.Text = "Selected Item";
            // 
            // comboBoxItem
            // 
            comboBoxItem.Anchor = AnchorStyles.None;
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Location = new Point(22, 279);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(178, 25);
            comboBoxItem.TabIndex = 0;
            comboBoxItem.SelectedIndexChanged += comboBoxItem_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(229, 101);
            label13.Name = "label13";
            label13.Size = new Size(119, 17);
            label13.TabIndex = 4;
            label13.Text = "Discount Per Item";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(444, 172);
            label12.Name = "label12";
            label12.Size = new Size(69, 17);
            label12.TabIndex = 9;
            label12.Text = "Final Cost";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Anchor = AnchorStyles.None;
            textBoxDiscount.ImeMode = ImeMode.Off;
            textBoxDiscount.Location = new Point(229, 134);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.ReadOnly = true;
            textBoxDiscount.Size = new Size(178, 25);
            textBoxDiscount.TabIndex = 2;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.None;
            buttonReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(126, 399);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(74, 30);
            buttonReset.TabIndex = 13;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(22, 400);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(74, 29);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(22, 320);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 3;
            label5.Text = "Unit Price";
            // 
            // textBoxUnitPrice
            // 
            textBoxUnitPrice.Anchor = AnchorStyles.None;
            textBoxUnitPrice.ImeMode = ImeMode.Off;
            textBoxUnitPrice.Location = new Point(22, 351);
            textBoxUnitPrice.Name = "textBoxUnitPrice";
            textBoxUnitPrice.ReadOnly = true;
            textBoxUnitPrice.Size = new Size(178, 25);
            textBoxUnitPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(229, 320);
            label4.Name = "label4";
            label4.Size = new Size(29, 17);
            label4.TabIndex = 7;
            label4.Text = "Tax";
            // 
            // textBoxTax
            // 
            textBoxTax.Anchor = AnchorStyles.None;
            textBoxTax.ImeMode = ImeMode.Off;
            textBoxTax.Location = new Point(229, 353);
            textBoxTax.Name = "textBoxTax";
            textBoxTax.ReadOnly = true;
            textBoxTax.Size = new Size(178, 25);
            textBoxTax.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(443, 101);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 8;
            label6.Text = "Total Cost";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(443, 320);
            label10.Name = "label10";
            label10.Size = new Size(54, 17);
            label10.TabIndex = 11;
            label10.Text = "Change";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(443, 101);
            label11.Name = "label11";
            label11.Size = new Size(70, 17);
            label11.TabIndex = 8;
            label11.Text = "Total Cost";
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(22, 14);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(599, 84);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 15;
            pictureBox.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.None;
            textBoxTotal.ImeMode = ImeMode.Off;
            textBoxTotal.Location = new Point(443, 134);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(178, 25);
            textBoxTotal.TabIndex = 6;
            // 
            // textBoxFinalCost
            // 
            textBoxFinalCost.Anchor = AnchorStyles.None;
            textBoxFinalCost.ImeMode = ImeMode.Off;
            textBoxFinalCost.Location = new Point(443, 203);
            textBoxFinalCost.Name = "textBoxFinalCost";
            textBoxFinalCost.ReadOnly = true;
            textBoxFinalCost.Size = new Size(178, 25);
            textBoxFinalCost.TabIndex = 7;
            // 
            // clear_Btn
            // 
            clear_Btn.Anchor = AnchorStyles.None;
            clear_Btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_Btn.Location = new Point(545, 575);
            clear_Btn.Name = "clear_Btn";
            clear_Btn.Size = new Size(76, 33);
            clear_Btn.TabIndex = 15;
            clear_Btn.Text = "Clear";
            clear_Btn.UseVisualStyleBackColor = true;
            clear_Btn.Visible = false;
            clear_Btn.Click += clear_Btn_Click;
            // 
            // insertBtn
            // 
            insertBtn.Anchor = AnchorStyles.None;
            insertBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertBtn.Location = new Point(229, 399);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(74, 30);
            insertBtn.TabIndex = 14;
            insertBtn.Text = "INSERT";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // PreviewqBtn
            // 
            PreviewqBtn.Anchor = AnchorStyles.None;
            PreviewqBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviewqBtn.Location = new Point(333, 400);
            PreviewqBtn.Name = "PreviewqBtn";
            PreviewqBtn.Size = new Size(180, 30);
            PreviewqBtn.TabIndex = 14;
            PreviewqBtn.Text = "PRINT PREVIEW";
            PreviewqBtn.UseVisualStyleBackColor = true;
            PreviewqBtn.Click += PreviewqBtn_Click;
            // 
            // printBtn
            // 
            printBtn.Anchor = AnchorStyles.None;
            printBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            printBtn.Location = new Point(548, 398);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(74, 30);
            printBtn.TabIndex = 14;
            printBtn.Text = "PRINT";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // RoyalMartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 631);
            Controls.Add(clear_Btn);
            Controls.Add(textBoxFinalCost);
            Controls.Add(textBoxTotal);
            Controls.Add(pictureBox);
            Controls.Add(dataGridView);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(printBtn);
            Controls.Add(PreviewqBtn);
            Controls.Add(insertBtn);
            Controls.Add(buttonReset);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxItem);
            Controls.Add(label3);
            Controls.Add(textBoxPaid);
            Controls.Add(textBoxTax);
            Controls.Add(label12);
            Controls.Add(textBoxSubtotal);
            Controls.Add(textBoxChange);
            Controls.Add(label4);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxDiscount);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(textBoxUnitPrice);
            Controls.Add(textBoxUser);
            Controls.Add(label2);
            Controls.Add(textBoxInvoice);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Name = "RoyalMartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Royal Mart";
            Load += MartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxPaid;
        private Label label8;
        private TextBox textBoxQuantity;
        private Label label7;
        private Label label1;
        private TextBox textBoxInvoice;
        private Label label2;
        private Label label9;
        private Label label14;
        private TextBox textBoxChange;
        private TextBox textBoxSubtotal;
        private TextBox textBoxUser;
        private Label label3;
        private ComboBox comboBoxItem;
        private Label label13;
        private Label label12;
        private TextBox textBoxDiscount;
        private Button buttonReset;
        private Button buttonAdd;
        private Label label5;
        private TextBox textBoxUnitPrice;
        private Label label4;
        private TextBox textBoxTax;
        private Label label6;
        private Label label10;
        private Label label11;
        private DataGridView dataGridView;
        private PictureBox pictureBox;
        private TextBox textBoxTotal;
        private TextBox textBoxFinalCost;
        private Button clear_Btn;
        private Button insertBtn;
        private Button PreviewqBtn;
        private Button printBtn;
        private PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}
