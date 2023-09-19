using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();


            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);
            this.Text = "MyEditor";


        }

        private void NewToolStripMenuItem__Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            this.Text = "MyEditor";
        }

        private void OpenToolStripMenuItem__Click(Object sender, EventArgs e) {
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
            richTextBox1.Cut();
        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e) {
            richTextBox1.Copy();
        }

        private void PasteToolStripMenuItem__Click(object sender, EventArgs e) {
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
