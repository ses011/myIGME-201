using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
 * Sleep tracker, but it insults you if you claim you sleep over 7 hours and will ignore you if you enter 4
 */
namespace UnitTest3_3
{
    public partial class Form1 : Form
    {
        Input[] data = new Input[8];
        public Form1()
        {
            InitializeComponent();

            this.historyButton.Click += new EventHandler(HistoryButton__Click);
            this.addButton.Click += new EventHandler(AddButton__Click);
            this.textBox1.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
        }

        // New window
        private void HistoryButton__Click(object sender, EventArgs e)
        {
            Form d = new Data(data);
            d.ShowDialog();
        }

        private void AddButton__Click(Object sender, EventArgs e)
        {
            int val = Int32.Parse(textBox1.Text);

            // Checks for first null spot in data, adds new value if hours slept isn't 4 or >= 8
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == null && val != 4 && !(val >= 8))
                {
                    data[i] = (new Input(dateTimePicker1.Value, val));
                    return;
                }
                // Calls user a liar if they say they've slept for 8 or more hours 
                else if (val >= 8)
                {
                    label2.Text = "Liar";
                    label2.ForeColor = Color.Red;
                    label2.Visible = true;
                    return;
                }

            }
            // Tells the user the array is full 
            if (data[8] == null)
            {
                label2.ForeColor = Color.Black;
                label2.Text = "No more space available :(";
                label2.Visible = true;
            }

        }

        // User can only enter digits and controls
        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    // Class to store date with hours slept, toString for value in list
    public class Input
    {
        DateTime date;
        int hours;
        public Input(DateTime d, int h)
        {
            this.date = d;
            this.hours = h;
        }

        public override string ToString()
        {
            return date.ToString().Split(' ')[0] + " you claimed to sleep " + hours.ToString() + " hours";
        }
    }
}
