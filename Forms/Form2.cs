using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSClub_Registration_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string message, string caption, string button)
        {
            InitializeComponent();

            //Set the message, caption, and button text
            label1.Text = message;
            Text = caption;
            button1.Text = button;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When the main button is pressed, close the window
            Close();
        }
    }
}
