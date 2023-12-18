using System;
using System.Windows.Forms;

namespace RMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeUI();
            this.Show();  
        }

        private void InitializeUI()
        {
            Label helloLabel = new Label();
            helloLabel.Text = "Hello, World!";
            helloLabel.AutoSize = true;

            this.Controls.Add(helloLabel); 
        }
    }
}
