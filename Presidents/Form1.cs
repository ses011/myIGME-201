using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Presidents : Form
    {
        public Presidents()
        {
            InitializeComponent();

            this.buttonBenHar.Click += new EventHandler(ButtonBenHar__Click);
            this.buttonFDR.Click += new EventHandler(ButtonFDR__Click);
            this.buttonWJC.Click += new EventHandler(ButtonWJC__Click);
            this.buttonJamBuc.Click += new EventHandler(ButtonJamBuc__Click);
            this.buttonFraPie.Click += new EventHandler(ButtonFraPie__Click);
            this.buttonGWB.Click += new EventHandler(ButtonGWB__Click);
            this.buttonBarOba.Click += new EventHandler(ButtonBarOba__Click);
            this.buttonJFK.Click += new EventHandler(ButtonJFK__Click);
            this.buttonWilMck.Click += new EventHandler(ButtonWilMck__Click);
            this.buttonRonReg.Click += new EventHandler(ButtonRonReg__Click);
            this.buttonDDE.Click += new EventHandler(ButtonDDE__Click);
            this.buttonMarVan.Click += new EventHandler(ButtonMarVan__Click);
            this.buttonGeoWas.Click += new EventHandler(ButtonGeoWas__Click);
            this.buttonJohAda.Click += new EventHandler(ButtonJohAda__Click);
            this.buttonTheRoo.Click += new EventHandler(ButtonTheRoo__Click);
            this.buttonThoJef.Click += new EventHandler(ButtonThoJef__Click);

            this.radioAll.Click += new EventHandler(RadioAll__Click);
            this.radioDem.Click += new EventHandler(RadioDem__Click);
            this.radioRep.Click += new EventHandler(RadioRep__Click);
            this.radioDemRep.Click += new EventHandler(RadioDemRep__Click);
            this.radioFed.Click += new EventHandler(RadioFed__Click);

            this.textBenHar.KeyPress += new KeyPressEventHandler(TextBenHar__KeyPress);
            this.textFDR.KeyPress += new KeyPressEventHandler(TexFDR__KeyPress);
            this.textWJC.KeyPress += new KeyPressEventHandler(TextWJC__KeyPress);
            this.textJamBuc.KeyPress += new KeyPressEventHandler(TextJamBuc__KeyPress);
            this.textFraPie.KeyPress += new KeyPressEventHandler(TextFraPie__KeyPress);
            this.textGWB.KeyPress += new KeyPressEventHandler(TextGWB__KeyPress);
            this.textBarOba.KeyPress += new KeyPressEventHandler(TextBarOba__KeyPress);
            this.textJFK.KeyPress += new KeyPressEventHandler(TextJFK__KeyPress);
            this.textWilMck.KeyPress += new KeyPressEventHandler(TextWilMck__KeyPress);
            this.textRonRea.KeyPress += new KeyPressEventHandler(TextRonRea__KeyPress);
            this.textDDE.KeyPress += new KeyPressEventHandler(TextDDE__KeyPress);
            this.textMarVan.KeyPress += new KeyPressEventHandler(TextMarVan__KeyPress);
            this.textGeoWas.KeyPress += new KeyPressEventHandler(TextGeoWas__KeyPress);
            this.textJohAda.KeyPress += new KeyPressEventHandler(TextJohAda__KeyPress);
            this.textTheRoo.KeyPress += new KeyPressEventHandler(TextTheRoo__KeyPress);
            this.textThoJef.KeyPress += new KeyPressEventHandler(TextThoJef__KeyPress);

            this.pictureBox1.MouseEnter += new EventHandler(PictureBox1__Enter);
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox1__Leave);

            this.timer1.Tick += new EventHandler(Timer__Tick);

            //this.Click += new EventHandler(Page__Click);
        }

        /*// Checks if current value is correct before letting user select different text box
        private void Page__Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.ActiveControl.Text) != Int32.Parse(this.ActiveControl.Tag.ToString()))
            {
                
            }
        }
*/

        // Timer
        private void Timer__Tick(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.PerformStep();
        }


        // President text box input validation and timer start
        private void TextBenHar__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TexFDR__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextWJC__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextJamBuc__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextFraPie__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextGWB__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBarOba__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextJFK__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextWilMck__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextRonRea__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextDDE__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextMarVan__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextGeoWas__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextJohAda__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextTheRoo__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextThoJef__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // Hover over image to change size - Not working???
        public void PictureBox1__Enter(object sender, EventArgs e)
        {
            this.pictureBox1.Size = new Size(230, 360);
        }
        public void PictureBox1__Leave(object sender, EventArgs e)
        {
            this.pictureBox1.Size = (new Size(160, 250));
        }

        // Party filters - show or hide the relevant radio buttons
        public void RadioAll__Click(object sender, EventArgs e)
        {
            buttonBenHar.Show();
            buttonBenHar.Select();
            buttonBarOba.Show();
            buttonDDE.Show();
            buttonMarVan.Show();
            buttonGeoWas.Show();
            buttonJohAda.Show();
            buttonTheRoo.Show();
            buttonThoJef.Show();
            buttonFDR.Show();
            buttonFraPie.Show();
            buttonWJC.Show();
            buttonJamBuc.Show();
            buttonGWB.Show();
            buttonJFK.Show();
            buttonWilMck.Show();
            buttonRonReg.Show();
        }
        public void RadioDem__Click(object sender, EventArgs e)
        {
            buttonBarOba.Show();
            buttonMarVan.Show();
            buttonFDR.Show();
            buttonFDR.Select();
            buttonFraPie.Show();
            buttonWJC.Show();
            buttonJFK.Show();
            buttonJamBuc.Show();
            buttonBenHar.Hide();
            buttonDDE.Hide();
            buttonThoJef.Hide();
            buttonGWB.Hide();
            buttonWilMck.Hide();
            buttonRonReg.Hide();
            buttonGeoWas.Hide();
            buttonJohAda.Hide();
            buttonTheRoo.Hide();
        }
        public void RadioRep__Click(object sender, EventArgs e)
        {
            buttonBarOba.Hide();
            buttonMarVan.Hide();
            buttonFDR.Hide();
            buttonFraPie.Hide();
            buttonWJC.Hide();
            buttonJFK.Hide();
            buttonJamBuc.Hide();
            buttonBenHar.Show();
            buttonBenHar.Select();
            buttonDDE.Show();
            buttonTheRoo.Show();
            buttonGWB.Show();
            buttonWilMck.Show();
            buttonRonReg.Show();
            buttonThoJef.Hide();
            buttonGeoWas.Hide();
            buttonJohAda.Hide();
        }
        public void RadioDemRep__Click(object sender, EventArgs e)
        {
            buttonBarOba.Hide();
            buttonMarVan.Hide();
            buttonFDR.Hide();
            buttonFraPie.Hide();
            buttonWJC.Hide();
            buttonJFK.Hide();
            buttonJamBuc.Hide();
            buttonBenHar.Hide();
            buttonDDE.Hide();
            buttonTheRoo.Hide();
            buttonGWB.Hide();
            buttonWilMck.Hide();
            buttonRonReg.Hide();
            buttonThoJef.Show();
            buttonThoJef.Select();
            buttonGeoWas.Hide();
            buttonJohAda.Hide();
        }
        public void RadioFed__Click(object sender, EventArgs e)
        {
            buttonBarOba.Hide();
            buttonMarVan.Hide();
            buttonFDR.Hide();
            buttonFraPie.Hide();
            buttonWJC.Hide();
            buttonJFK.Hide();
            buttonJamBuc.Hide();
            buttonBenHar.Hide();
            buttonDDE.Hide();
            buttonTheRoo.Hide();
            buttonGWB.Hide();
            buttonWilMck.Hide();
            buttonRonReg.Hide();
            buttonThoJef.Hide();
            buttonGeoWas.Show();
            buttonGeoWas.Select();
            buttonJohAda.Show();
        }


        // President radio buttons - Shows image and wikipedia page
        public void ButtonBenHar__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
        }
        public void ButtonFDR__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
        }
        public void ButtonWJC__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Bill_Clinton");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Bill_Clinton";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";

        }
        public void ButtonJamBuc__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/James_Buchanan");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";

        }
        public void ButtonFraPie__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
        }
        public void ButtonGWB__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/George_W._Bush");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/George_W._Bush";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
        }
        public void ButtonBarOba__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Barack_Obama");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";

        }
        public void ButtonJFK__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/John_F._Kennedy");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/John_F._Kennedy";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";

        }
        public void ButtonWilMck__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/William_McKinley");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";

        }
        public void ButtonRonReg__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";

        }
        public void ButtonDDE__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Dwight_D";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";

        }
        public void ButtonMarVan__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Martin_Van_Buren");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Martin_Van_Buren";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";

        }
        public void ButtonGeoWas__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/George_Washington");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";

        }
        public void ButtonJohAda__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/John_Adams");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";

        }
        public void ButtonTheRoo__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";

        }
        public void ButtonThoJef__Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
            this.groupBox1.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";

        }

    }
}
