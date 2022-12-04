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
    public partial class GameForm : Form
    {
        public int nRandom;
        public int nGuesses = 0;
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            Random rand = new Random();
            nRandom = rand.Next(lowNumber, highNumber);

            this.guessButton.Click += new EventHandler(GuessButton__Click);
            this.currentGuessTextBox.KeyPress += new KeyPressEventHandler(GuessTextBox__KeyPress);

            this.timer.Tick += new EventHandler(Timer__Tick);

            this.timer.Interval = 1000;
            this.toolStripProgressBar.Value = 45;

            this.timer.Start();


            // The timer’s tick event will need to update the progress bar accordingly
            // and potentially cause the game to be over after 45 seconds has elapsed

            // MessageBox.Show($"Out of time! The answer was {___}.");
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            //  update the output label after each guess letting the user know if they were high or low
            // and clear their guess

            int guess = Int32.Parse(this.currentGuessTextBox.Text);

            if (guess < nRandom)
            {
                this.outputLabel.Text = currentGuessTextBox.Text + " is too low";
            }
            else if (guess > nRandom)
            {
                this.outputLabel.Text = currentGuessTextBox.Text + " is too high";
            }
            else {
                this.timer.Stop();
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");

                this.Close();
            }

            // clear their guess after

            this.currentGuessTextBox.Text = "";
            nGuesses++;
        }

        private void GuessTextBox__KeyPress(object sender, KeyPressEventArgs e)
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

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;

            if (this.toolStripProgressBar.Value == 0)
            {
                this.timer.Stop();

                MessageBox.Show($"Out of time! The answer was {nRandom}.");

                this.Close();
            }
        }
    }
}
