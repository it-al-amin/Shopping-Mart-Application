namespace Shopping_Mart_Application
{
    partial class loginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            txtPassword = new TextBox();
            txtUser = new TextBox();
            loginLabel = new Label();
            pictureBox = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            linkLabel1 = new LinkLabel();
            checkBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 9.75F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(201, 262);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(169, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.BackColor = Color.WhiteSmoke;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 9.75F);
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(201, 210);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(169, 23);
            txtUser.TabIndex = 5;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.None;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            loginLabel.ForeColor = SystemColors.ActiveCaptionText;
            loginLabel.Location = new Point(241, 156);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(80, 22);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "LOG IN ";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(185, 37);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(169, 103);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 12;
            pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Black;
            panel2.ForeColor = Color.Silver;
            panel2.Location = new Point(170, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(170, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(170, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.None;
            LoginBtn.AutoSize = true;
            LoginBtn.BackColor = Color.LightGray;
            LoginBtn.BackgroundImageLayout = ImageLayout.Center;
            LoginBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            LoginBtn.ForeColor = SystemColors.ActiveCaptionText;
            LoginBtn.Location = new Point(170, 341);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(200, 33);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.PaleGoldenrod;
            linkLabel1.DisabledLinkColor = Color.Silver;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.Lime;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(170, 391);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(217, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Yet not registered? Click here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox
            // 
            checkBox.Anchor = AnchorStyles.None;
            checkBox.AutoSize = true;
            checkBox.BackColor = Color.LightGray;
            checkBox.Location = new Point(170, 298);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(121, 21);
            checkBox.TabIndex = 15;
            checkBox.Text = "Show password";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(541, 452);
            Controls.Add(checkBox);
            Controls.Add(linkLabel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(loginLabel);
            Controls.Add(pictureBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUser;
        private Label loginLabel;
        private PictureBox pictureBox;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private LinkLabel linkLabel1;
        private CheckBox checkBox;
    }
}