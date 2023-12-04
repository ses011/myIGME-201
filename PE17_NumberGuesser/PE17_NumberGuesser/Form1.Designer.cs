namespace PE17_NumberGuesser
{
    partial class Range
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
            this.promptLlabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highNumLabel = new System.Windows.Forms.Label();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLlabel
            // 
            this.promptLlabel.AutoSize = true;
            this.promptLlabel.Location = new System.Drawing.Point(38, 21);
            this.promptLlabel.Name = "promptLlabel";
            this.promptLlabel.Size = new System.Drawing.Size(151, 13);
            this.promptLlabel.TabIndex = 0;
            this.promptLlabel.Text = "Enter range of values to guess";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(12, 62);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(67, 13);
            this.lowLabel.TabIndex = 1;
            this.lowLabel.Text = "Low Number";
            // 
            // highNumLabel
            // 
            this.highNumLabel.Location = new System.Drawing.Point(12, 98);
            this.highNumLabel.Name = "highNumLabel";
            this.highNumLabel.Size = new System.Drawing.Size(74, 13);
            this.highNumLabel.TabIndex = 0;
            this.highNumLabel.Text = "High Number";
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(101, 59);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(81, 20);
            this.lowTextBox.TabIndex = 2;
            this.lowTextBox.Text = "1";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(101, 95);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(81, 20);
            this.highTextBox.TabIndex = 3;
            this.highTextBox.Text = "100";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(75, 138);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Range
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 171);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.highNumLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.promptLlabel);
            this.Name = "Range";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLlabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highNumLabel;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.Button startButton;
    }
}

