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
    public partial class Range : Form
    {
        public Range()
        {
            InitializeComponent();

            startButton.Click += new EventHandler(StartButton__Click);
            lowTextBox.KeyPress += new KeyPressEventHandler(LowTextBox__KeyPress);
            highTextBox.KeyPress += new KeyPressEventHandler(HighTextBox__KeyPress);
            
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            int lowNum;
            int highNum;

            // Try to save low and high nums as ints
            // if it works and low is < high, make new game form and return
            try
            {
                lowNum = Int32.Parse(lowTextBox.Text);
                highNum = Int32.Parse(highTextBox.Text);


                if (lowNum < highNum)
                {
                    GameForm gameForm = new GameForm(lowNum, highNum);
                    gameForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Low number is larger than high number.");
                }
                return;
            }
            // If it doesn't work display error message
            catch
            {
                MessageBox.Show("The numbers are invalid.");
            }

        }

        private void LowTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HighTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
