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

namespace UnitTest3_3
{
    public partial class Data : Form
    {
        public Data(Input[] data)
        {
            InitializeComponent();

            // adds every non-null value of data to the list view
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null)
                {
                    ListViewItem val = new ListViewItem(data[i].ToString());
                    val.Text = data[i].ToString();
                    listView1.Items.Add(val);
                }
            }
        }
    }
}
