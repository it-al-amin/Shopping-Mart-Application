using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Mart_Application
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            SetupHelpContent();
        }
        private void SetupHelpContent()
        {
            // PictureBox setup for adding an image
            PictureBox picSearchExample = new PictureBox
            {
                Location = new Point(20, 20), // Display picture first
                Size = new Size(460, 75),
                SizeMode = PictureBoxSizeMode.StretchImage,
              
            };

            // Attempt to load the image and handle potential file not found exception
            try
            {
                picSearchExample.Image = Image.FromFile(@"..\..\..\royal_mart.jpg");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Image file 'royal_mart.jpg' not found. Please ensure the image is in the correct location.",
                                "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Example setup for 'Getting Started' section
            Label lblGettingStarted = new Label
            {
                Text = "Getting Started",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(20, 130), // Adjust position below the picture
                AutoSize = true
            };

            RichTextBox rtbGettingStarted = new RichTextBox
            {
                Text = "To get started with Mart Shopping, log in or register as a new user.\n" +
                       "Once logged in, you can browse through categories or search for specific items.",
                Location = new Point(20, 160),
                Size = new Size(460, 80),
                ReadOnly = true
            };

            // Example setup for 'Searching for Products' section
            Label lblSearchingProducts = new Label
            {
                Text = "Searching for Products",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(20, 260), // Adjust position below the previous section
                AutoSize = true
            };

            RichTextBox rtbSearchingProducts = new RichTextBox
            {
                Text = "Use the search bar at the top of the main page to look for specific products.\n" +
                       "You can also use filters to narrow down your search by category or price range.",
                Location = new Point(20, 290),
                Size = new Size(460, 80),
                ReadOnly = true
            };

            // Add controls to the form
            this.Controls.Add(picSearchExample);
            this.Controls.Add(lblGettingStarted);
            this.Controls.Add(rtbGettingStarted);
            this.Controls.Add(lblSearchingProducts);
            this.Controls.Add(rtbSearchingProducts);

            // Add Close button to exit help form
            Button btnClose = new Button
            {
                Text = "Close",
                Location = new Point(20, 400),
                Size = new Size(80, 30)
            };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

    }
}
