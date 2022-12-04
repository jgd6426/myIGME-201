namespace GuessingGame
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.lowNumberLabel = new System.Windows.Forms.Label();
            this.highNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lowNumberTextBox = new System.Windows.Forms.TextBox();
            this.highNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(100, 137);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // lowNumberLabel
            // 
            this.lowNumberLabel.AutoSize = true;
            this.lowNumberLabel.Location = new System.Drawing.Point(35, 58);
            this.lowNumberLabel.Name = "lowNumberLabel";
            this.lowNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.lowNumberLabel.TabIndex = 1;
            this.lowNumberLabel.Text = "Low Number:";
            // 
            // highNumberLabel
            // 
            this.highNumberLabel.AutoSize = true;
            this.highNumberLabel.Location = new System.Drawing.Point(33, 92);
            this.highNumberLabel.Name = "highNumberLabel";
            this.highNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.highNumberLabel.TabIndex = 2;
            this.highNumberLabel.Text = "High Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Range of Values to Guess";
            // 
            // lowNumberTextBox
            // 
            this.lowNumberTextBox.Location = new System.Drawing.Point(129, 55);
            this.lowNumberTextBox.Name = "lowNumberTextBox";
            this.lowNumberTextBox.Size = new System.Drawing.Size(112, 20);
            this.lowNumberTextBox.TabIndex = 4;
            this.lowNumberTextBox.Text = "1";
            // 
            // highNumberTextBox
            // 
            this.highNumberTextBox.Location = new System.Drawing.Point(129, 89);
            this.highNumberTextBox.Name = "highNumberTextBox";
            this.highNumberTextBox.Size = new System.Drawing.Size(112, 20);
            this.highNumberTextBox.TabIndex = 5;
            this.highNumberTextBox.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 172);
            this.Controls.Add(this.highNumberTextBox);
            this.Controls.Add(this.lowNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highNumberLabel);
            this.Controls.Add(this.lowNumberLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label lowNumberLabel;
        private System.Windows.Forms.Label highNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lowNumberTextBox;
        private System.Windows.Forms.TextBox highNumberTextBox;
    }
}

