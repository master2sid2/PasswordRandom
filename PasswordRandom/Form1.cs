using System;
using System.Windows.Forms;

namespace PasswordRandom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void passLenghtTrackBar_Scroll(object sender, EventArgs e)
        {
            passLenghtLabel.Text = passLenghtTrackBar.Value.ToString();
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            passTextBox1.Clear();
            for (int i=0; i<=passLenghtTrackBar.Value; i++)
            {
                passTextBox1.AppendText(PlaceSymbol().ToString());
            }
        }

        private char PlaceSymbol()
        {
            return (char)randomNumberGen();
        }

        private int randomNumberGen()
        {
            return random.Next(33, 126);
        }
    }
}
