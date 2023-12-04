namespace PE17_NumberGuesser
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimerToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.guessButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(224, 169);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess:";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(217, 65);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 20);
            this.guessTextBox.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimerToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 233);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimerToolStripProgressBar
            // 
            this.TimerToolStripProgressBar.Maximum = 450;
            this.TimerToolStripProgressBar.Name = "TimerToolStripProgressBar";
            this.TimerToolStripProgressBar.Size = new System.Drawing.Size(450, 16);
            this.TimerToolStripProgressBar.Step = 5;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(202, 118);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 4;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AcceptButton = this.guessButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 255);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar TimerToolStripProgressBar;
        private System.Windows.Forms.Button guessButton;
    }
}