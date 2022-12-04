using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.lowNumberTextBox.KeyPress += new KeyPressEventHandler(NumberTextBox__KeyPress);
            this.highNumberTextBox.KeyPress += new KeyPressEventHandler(NumberTextBox__KeyPress);

            this.startButton.Click += new EventHandler(StartButton__Click);      
        }

        private void NumberTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow the user to type digits in the text boxes

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            int lowNumber = 0;
            int highNumber = 100;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse

            lowNumber = Int32.Parse(this.lowNumberTextBox.Text);
            highNumber = Int32.Parse(this.highNumberTextBox.Text);

            // if not in a valid range
            if (lowNumber >= highNumber)
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog,
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }
    }
}
