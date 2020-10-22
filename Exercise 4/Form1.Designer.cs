namespace Exercise_4
{
    partial class timeConversionForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.enterTimePromptLabel = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.timeCalculated = new System.Windows.Forms.Label();
            this.enterTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(533, 331);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(218, 330);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "C&lear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // enterTimePromptLabel
            // 
            this.enterTimePromptLabel.AutoSize = true;
            this.enterTimePromptLabel.Location = new System.Drawing.Point(228, 128);
            this.enterTimePromptLabel.Name = "enterTimePromptLabel";
            this.enterTimePromptLabel.Size = new System.Drawing.Size(179, 13);
            this.enterTimePromptLabel.TabIndex = 3;
            this.enterTimePromptLabel.Text = "Enter an amount of time in seconds: ";
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Location = new System.Drawing.Point(322, 217);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(85, 13);
            this.timeElapsedLabel.TabIndex = 4;
            this.timeElapsedLabel.Text = "Calculated time: ";
            // 
            // timeCalculated
            // 
            this.timeCalculated.AutoSize = true;
            this.timeCalculated.Location = new System.Drawing.Point(428, 217);
            this.timeCalculated.Name = "timeCalculated";
            this.timeCalculated.Size = new System.Drawing.Size(35, 13);
            this.timeCalculated.TabIndex = 5;
            this.timeCalculated.Text = "label1";
            // 
            // enterTimeTextBox
            // 
            this.enterTimeTextBox.Location = new System.Drawing.Point(431, 125);
            this.enterTimeTextBox.Name = "enterTimeTextBox";
            this.enterTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterTimeTextBox.TabIndex = 6;
            // 
            // timeConversionForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterTimeTextBox);
            this.Controls.Add(this.timeCalculated);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.enterTimePromptLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Name = "timeConversionForm";
            this.Text = "Elapsed Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label enterTimePromptLabel;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Label timeCalculated;
        private System.Windows.Forms.TextBox enterTimeTextBox;
    }
}

