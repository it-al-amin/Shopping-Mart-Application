namespace Shopping_Mart_Application
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            pictureBox = new PictureBox();
            labelSignup = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelname = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            comboBox = new ComboBox();
            numericUpDown = new NumericUpDown();
            textBoxAddress = new TextBox();
            textBoxEamil = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmsPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            SignupBtn = new Button();
            label2 = new Label();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(7, 11);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(684, 79);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            // 
            // labelSignup
            // 
            labelSignup.Anchor = AnchorStyles.None;
            labelSignup.AutoSize = true;
            labelSignup.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSignup.Location = new Point(270, 93);
            labelSignup.Name = "labelSignup";
            labelSignup.Size = new Size(154, 24);
            labelSignup.TabIndex = 17;
            labelSignup.Text = "SIGNUP FORM";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(label3, 0, 2);
            tableLayoutPanel.Controls.Add(label4, 0, 3);
            tableLayoutPanel.Controls.Add(label5, 0, 4);
            tableLayoutPanel.Controls.Add(label6, 0, 5);
            tableLayoutPanel.Controls.Add(labelname, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxSurname, 1, 1);
            tableLayoutPanel.Controls.Add(comboBox, 1, 2);
            tableLayoutPanel.Controls.Add(numericUpDown, 1, 3);
            tableLayoutPanel.Controls.Add(textBoxAddress, 1, 4);
            tableLayoutPanel.Controls.Add(textBoxEamil, 1, 5);
            tableLayoutPanel.Controls.Add(textBoxPassword, 1, 6);
            tableLayoutPanel.Controls.Add(textBoxConfirmsPassword, 1, 7);
            tableLayoutPanel.Controls.Add(label8, 0, 7);
            tableLayoutPanel.Controls.Add(label7, 0, 6);
            tableLayoutPanel.Controls.Add(SignupBtn, 0, 8);
            tableLayoutPanel.Controls.Add(label2, 0, 1);
            tableLayoutPanel.Controls.Add(resetBtn, 1, 8);
            tableLayoutPanel.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            tableLayoutPanel.Location = new Point(130, 119);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.Size = new Size(469, 302);
            tableLayoutPanel.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(60, 16);
            label3.TabIndex = 0;
            label3.Text = "GENDER";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(3, 107);
            label4.Name = "label4";
            label4.Size = new Size(34, 16);
            label4.TabIndex = 0;
            label4.Text = "AGE";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(3, 140);
            label5.Name = "label5";
            label5.Size = new Size(69, 16);
            label5.TabIndex = 0;
            label5.Text = "ADDRESS";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label6.Location = new Point(3, 173);
            label6.Name = "label6";
            label6.Size = new Size(47, 16);
            label6.TabIndex = 0;
            label6.Text = "EMAIL";
            // 
            // labelname
            // 
            labelname.Anchor = AnchorStyles.Left;
            labelname.AutoSize = true;
            labelname.BackColor = Color.Transparent;
            labelname.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            labelname.Location = new Point(3, 8);
            labelname.Name = "labelname";
            labelname.Size = new Size(44, 16);
            labelname.TabIndex = 0;
            labelname.Text = "NAME";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left;
            textBoxName.Location = new Point(237, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "   Enter Your Name";
            textBoxName.Size = new Size(227, 22);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Left;
            textBoxSurname.Location = new Point(237, 38);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.PlaceholderText = "   Enter Your SurName";
            textBoxSurname.Size = new Size(227, 22);
            textBoxSurname.TabIndex = 1;
            // 
            // comboBox
            // 
            comboBox.Anchor = AnchorStyles.Left;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "   Please Select One", "Male", "Famale" });
            comboBox.Location = new Point(237, 71);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(227, 24);
            comboBox.TabIndex = 2;
            // 
            // numericUpDown
            // 
            numericUpDown.Anchor = AnchorStyles.Left;
            numericUpDown.Location = new Point(237, 104);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(227, 22);
            numericUpDown.TabIndex = 3;
            numericUpDown.TextAlign = HorizontalAlignment.Center;
            numericUpDown.UpDownAlign = LeftRightAlignment.Left;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left;
            textBoxAddress.Location = new Point(237, 137);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "   Enter Your Address";
            textBoxAddress.Size = new Size(227, 22);
            textBoxAddress.TabIndex = 4;
            // 
            // textBoxEamil
            // 
            textBoxEamil.Anchor = AnchorStyles.Left;
            textBoxEamil.Location = new Point(237, 170);
            textBoxEamil.Name = "textBoxEamil";
            textBoxEamil.PlaceholderText = "   Enter Your Email";
            textBoxEamil.Size = new Size(227, 22);
            textBoxEamil.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left;
            textBoxPassword.Location = new Point(237, 203);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "   Enter Your Password";
            textBoxPassword.Size = new Size(227, 22);
            textBoxPassword.TabIndex = 6;
            // 
            // textBoxConfirmsPassword
            // 
            textBoxConfirmsPassword.Anchor = AnchorStyles.Left;
            textBoxConfirmsPassword.Location = new Point(237, 236);
            textBoxConfirmsPassword.Name = "textBoxConfirmsPassword";
            textBoxConfirmsPassword.PlaceholderText = "    Re Enter Your Password";
            textBoxConfirmsPassword.Size = new Size(227, 22);
            textBoxConfirmsPassword.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label8.Location = new Point(3, 239);
            label8.Name = "label8";
            label8.Size = new Size(147, 16);
            label8.TabIndex = 0;
            label8.Text = "CONFIRM PASSWORD";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(3, 206);
            label7.Name = "label7";
            label7.Size = new Size(83, 16);
            label7.TabIndex = 0;
            label7.Text = "PASSWORD";
            // 
            // SignupBtn
            // 
            SignupBtn.Anchor = AnchorStyles.None;
            SignupBtn.BackColor = Color.LightGray;
            SignupBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            SignupBtn.Location = new Point(54, 268);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(126, 30);
            SignupBtn.TabIndex = 8;
            SignupBtn.Text = "SIGNUP";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 0;
            label2.Text = "SURNAME";
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.None;
            resetBtn.BackColor = Color.LightGray;
            resetBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            resetBtn.Location = new Point(288, 268);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(126, 30);
            resetBtn.TabIndex = 9;
            resetBtn.Text = "RESET";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(696, 522);
            Controls.Add(tableLayoutPanel);
            Controls.Add(labelSignup);
            Controls.Add(pictureBox);
            Font = new Font("Arial", 9.75F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label labelSignup;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelname;
        private TextBox textBoxName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxSurname;
        private ComboBox comboBox;
        private NumericUpDown numericUpDown;
        private TextBox textBoxAddress;
        private TextBox textBoxEamil;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmsPassword;
        private Button SignupBtn;
        private Button resetBtn;
    }
}