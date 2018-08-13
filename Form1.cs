using System;
using System.IO;
using System.Windows.Forms;

namespace CSClub_Registration_App
{
    public partial class Form1 : Form
    {
        //The directory of the text file
        private readonly string TextFileLocation;

        public Form1()
        {
            InitializeComponent();

            //Fetch where the current .exe is, and write to a text file there
            TextFileLocation = Environment.CurrentDirectory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check if any of the text boxes are empty
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                //Show an error message and break from the function
                Form2 ErrorMessage = new Form2("Sorry, you've left one or more of the boxes blank!", "CS Club Signup", "Oops!");
                ErrorMessage.ShowDialog();
                return;
            }

            try
            {
                //Fetch the data
                string FirstName = textBox1.Text;
                string LastName = textBox2.Text;
                string Email = textBox3.Text;

                //Write to the text file
                File.AppendAllText(TextFileLocation + @"\Names.txt", LastName + ", " + FirstName + " - " + Email + Environment.NewLine);
            }
            catch (Exception ex)
            {
                //If this runs, we've encountered a small error, likely with File.AppendAllText()
                Form2 ErrorMessage = new Form2("Oops! Something went wrong! Please talk to Phil.", "CS Club Signup", "Uh oh");
                ErrorMessage.ShowDialog();
                MessageBox.Show(ex.ToString()); //Make sure the error is shown
                return;
            }

            //Congrats! You've signed up
            Form2 DialogConfirmation = new Form2("Submitted!", "CS Club Signup", "Yay!");
            DialogConfirmation.ShowDialog();

            //Clear the boxes
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            //Check if the enter key was pressed, and hit the button if it was
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, new EventArgs());
        }
    }
}
