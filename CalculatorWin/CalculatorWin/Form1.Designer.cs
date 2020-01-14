namespace CalculatorWin
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.eroButton = new System.Windows.Forms.Button();
            this.kertoButton = new System.Windows.Forms.Button();
            this.jakoButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(86, 68);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(463, 17);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Enter a decimal numbers and select an aritmetic operation into the fields";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 2;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(89, 206);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(51, 41);
            this.sumButton.TabIndex = 3;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // eroButton
            // 
            this.eroButton.Location = new System.Drawing.Point(174, 206);
            this.eroButton.Name = "eroButton";
            this.eroButton.Size = new System.Drawing.Size(51, 41);
            this.eroButton.TabIndex = 4;
            this.eroButton.Text = "-";
            this.eroButton.UseVisualStyleBackColor = true;
            this.eroButton.Click += new System.EventHandler(this.EroButton_Click);
            // 
            // kertoButton
            // 
            this.kertoButton.Location = new System.Drawing.Point(268, 206);
            this.kertoButton.Name = "kertoButton";
            this.kertoButton.Size = new System.Drawing.Size(51, 41);
            this.kertoButton.TabIndex = 5;
            this.kertoButton.Text = "*";
            this.kertoButton.UseVisualStyleBackColor = true;
            this.kertoButton.Click += new System.EventHandler(this.KertoButton_Click);
            // 
            // jakoButton
            // 
            this.jakoButton.Location = new System.Drawing.Point(368, 206);
            this.jakoButton.Name = "jakoButton";
            this.jakoButton.Size = new System.Drawing.Size(51, 41);
            this.jakoButton.TabIndex = 6;
            this.jakoButton.Text = "/";
            this.jakoButton.UseVisualStyleBackColor = true;
            this.jakoButton.Click += new System.EventHandler(this.JakoButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(225, 302);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.jakoButton);
            this.Controls.Add(this.kertoButton);
            this.Controls.Add(this.eroButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button eroButton;
        private System.Windows.Forms.Button kertoButton;
        private System.Windows.Forms.Button jakoButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

