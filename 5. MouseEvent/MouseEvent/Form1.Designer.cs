namespace MouseEvent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.jButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.jButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.panel1.Location = new System.Drawing.Point(179, 65);
            this.panel1.Name = "panel1";
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.Size = new System.Drawing.Size(447, 199);
            this.panel1.TabIndex = 0;
            // 
            // jButton
            // 
            this.jButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jButton.Location = new System.Drawing.Point(143, 87);
            this.jButton.Name = "jButton";
            this.jButton.Size = new System.Drawing.Size(185, 31);
            this.jButton.TabIndex = 0;
            this.jButton.Text = "button1";
            this.jButton.MouseEnter += new System.EventHandler(this.jButton_MouseEnter);
            this.jButton.UseVisualStyleBackColor = true;
            this.jButton.Click += new System.EventHandler(this.JButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_MouseEnter(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button jButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

