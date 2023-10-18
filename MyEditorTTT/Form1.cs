using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1(MyEditorParent myEditorParent) {
            InitializeComponent();

            this.MdiParent = myEditorParent;


            //this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            myEditorParent.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            myEditorParent.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            //this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            myEditorParent.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            myEditorParent.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);
            myEditorParent.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            myEditorParent.closeAllToolStripMenuItem.Click += new EventHandler(CloseAllToolStripMenuItem__Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);

            this.testToolStripButton.Click += new EventHandler(TestToolStripButton__Click);

            this.richTextBox1.SelectionChanged += new EventHandler(richTextBox1__SelectionChanged);
            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);

            this.countdownLabel.Visible = false;

            this.timer.Tick += new EventHandler(Timer__Tick);

            this.Text = "MyEditor";

            this.FormClosing += new FormClosingEventHandler(Form1__FormClosing);
        }

        private void Form1__FormClosing(object sender, FormClosingEventArgs e) {
            MyEditorParent myEditorParent = (MyEditorParent)this.MdiParent;

            myEditorParent.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            myEditorParent.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);

            myEditorParent.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            myEditorParent.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);
            myEditorParent.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            myEditorParent.closeAllToolStripMenuItem.Click += new EventHandler(CloseAllToolStripMenuItem__Click);
        }

        private void CloseAllToolStripMenuItem__Click(object sender, EventArgs e) {
            this.Close();
        }
        private void NewToolStripMenuItem__Click(Object sender, EventArgs e) {
            richTextBox1.Clear();
            this.Text = "MyEditor";
        }

        private void BoldToolStripMenuItem__Click(Object sender, EventArgs e) {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null) {
                selectionFont = richTextBox1.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        private void TestToolStripButton__Click(object sender, EventArgs e) {
            this.timer.Interval = 500;
            this.toolStripProgressBar.Value = 60;

            this.countdownLabel.Text = "3";
            this.countdownLabel.Visible = true;
            this.richTextBox1.Visible = false;

            for(int i = 3; i > 0; --i) {
                this.countdownLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }

            this.countdownLabel.Visible = false;
            this.richTextBox1.Visible = true;

            this.timer.Start();
        }

        private void Timer__Tick(Object sender, EventArgs e) {
            --this.toolStripProgressBar.Value;

            if (this.toolStripProgressBar.Value == 0) {
                this.timer.Stop();

                string performance = "Congrats! You typed " + Math.Round(this.richTextBox1.TextLength / 30.0, 2) + " letters per second!";

                MessageBox.Show(performance);
            }

        }

        private void ItalicsToolStripMenuItem__Click(Object sender, EventArgs e) {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null) {
                selectionFont = richTextBox1.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        private void UnderlineToolStripMenuItem__Click(Object sender, EventArgs e) {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null) {
                selectionFont = richTextBox1.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }

        private void MSSansSerifToolStripMenuItem__Click(Object sender, EventArgs e) {
            Font newFont = new Font("MS Sans Serif", richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            richTextBox1.SelectionFont = newFont;
        }

        private void TimesNewRomanToolStripMenuItem__Click(Object sender, EventArgs e) {
            Font newFont = new Font("Times New Roman", richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            richTextBox1.SelectionFont = newFont;
        }

        private void richTextBox1__SelectionChanged(Object sender, EventArgs e) {
            if (this.richTextBox1.SelectionFont != null) {
                this.boldToolStripMenuItem.Checked = richTextBox1.SelectionFont.Bold;
                this.italicsToolStripMenuItem.Checked = richTextBox1.SelectionFont.Italic;
                this.underlineToolStripMenuItem.Checked = richTextBox1.SelectionFont.Underline;
            }

            this.toolStripColorButton.BackColor = richTextBox1.SelectionColor;
        }

        private void OpenToolStripMenuItem__Click(Object sender, EventArgs e) {
            if(this.MdiParent.ActiveMdiChild != this) {
                return;
            }

            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog1.FileName.ToLower().Contains(".txt")) {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox1.LoadFile(openFileDialog1.FileName, richTextBoxStreamType);
                this.Text = "MyEditor (" + openFileDialog1.FileName + ")";
            }
        }

        private void SaveToolStripMenuItem__Click(Object sender, EventArgs e) {
            if (this.MdiParent.ActiveMdiChild != this) {
                return;
            }

            saveFileDialog1.FileName = openFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog1.FileName.ToLower().Contains(".txt")) {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox1.SaveFile(saveFileDialog1.FileName, richTextBoxStreamType);
                this.Text = "MyEditor (" + saveFileDialog1.FileName + ")";
            }
        }

        private void ExitToolStripMenuItem__Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void CutToolStripMenuItem__Click(object sender, EventArgs e) {
            if (this.MdiParent.ActiveMdiChild != this) {
                return;
            }
            richTextBox1.Cut();
        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e) {
            if (this.MdiParent.ActiveMdiChild != this) {
                return;
            }
            richTextBox1.Copy();
        }

        private void PasteToolStripMenuItem__Click(object sender, EventArgs e) {
            if (this.MdiParent.ActiveMdiChild != this) {
                return;
            }
            richTextBox1.Paste();
        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if(e.ClickedItem == this.toolStripBoldButton) {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.toolStripBoldButton;
            }
            else if (e.ClickedItem == this.toolStripItalicsButton) {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.toolStripItalicsButton;
            }
            else if (e.ClickedItem == this.toolStripUnderlineButton) {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.toolStripUnderlineButton;
            }
            else if(e.ClickedItem == this.toolStripColorButton) {
                if(colorDialog1.ShowDialog() == DialogResult.OK) {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                    toolStripColorButton.BackColor = colorDialog1.Color;

                }
            }

            if( fontStyle != FontStyle.Regular ) {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        public void SetSelectionFont(FontStyle fontStyle, bool selected) {
            Font newFont;
            Font selectionFont;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null) {
                selectionFont = richTextBox1.Font;
            }

            if (selected) {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox1.SelectionFont = newFont;
        }
    }
}
