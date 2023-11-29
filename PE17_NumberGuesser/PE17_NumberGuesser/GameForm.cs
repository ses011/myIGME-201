using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17_NumberGuesser
{
    public partial class GameForm : Form
    {
        int num;
        int guesses = 0;

        public GameForm(int lowNum, int highNum)
        {
            InitializeComponent();

            // Generate number to guess
            Random rand = new Random();
            num = rand.Next(lowNum, highNum + 1);
            this.timer1.Enabled = true;

            this.guessButton.Click += new EventHandler(GuessButton__Click);
            //this.guessButton.KeyPress += new KeyPressEventHandler(GuessButton__KeyPress);
            this.timer1.Tick += new EventHandler(Timer__Tick);
        }


        private void TimesUp()
        {
            // Timer has exceeded 45 seconds
            this.guessTextBox.Enabled = false;
            this.guessButton.Enabled = false;

            MessageBox.Show($"Times up! The number was {num}");
            this.Close();
        }


        private void GuessButton__Click(object sender, EventArgs e)
        {
            int guess = Int32.Parse(guessTextBox.Text);
            if (guess == num)
            {
                // Display success messages
                guesses++;
                this.outputLabel.ForeColor = Color.Green;
                this.outputLabel.Text = "Correct!";
                this.timer1.Enabled = false;
                MessageBox.Show($"You got it in {guesses} attempts!");

                this.Close();
            }
            // Changes hint if guess is incorrect
            else if(guess < num)
            {
                this.outputLabel.Text = $"{guess} is too low";
                this.guesses++;
            }
            else
            {
                this.outputLabel.Text = $"{guess} is too high";
                guesses++;
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            this.TimerToolStripProgressBar.PerformStep();

            // Progress bar increases by 5 every half second, making 450 the value for 45 seconds
            if (this.TimerToolStripProgressBar.Value >= 450)
            {
                this.timer1.Enabled = false;
                TimesUp();
            }
        }
    }
}
