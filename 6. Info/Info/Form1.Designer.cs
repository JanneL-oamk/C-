namespace Info
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
            this.labelNickName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1Age = new System.Windows.Forms.RadioButton();
            this.radioButton2Age = new System.Windows.Forms.RadioButton();
            this.radioButton3Age = new System.Windows.Forms.RadioButton();
            this.checkBoxIceCream = new System.Windows.Forms.CheckBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.listBoxCountry = new System.Windows.Forms.ListBox();
            this.groupBoxAge = new System.Windows.Forms.GroupBox();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.textBoxPrint = new System.Windows.Forms.TextBox();
            this.groupBoxAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNickName
            // 
            this.labelNickName.AutoSize = true;
            this.labelNickName.Location = new System.Drawing.Point(53, 61);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(70, 17);
            this.labelNickName.TabIndex = 0;
            this.labelNickName.Text = "Nickname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "I like to live in";
            // 
            // radioButton1Age
            // 
            this.radioButton1Age.AutoSize = true;
            this.radioButton1Age.Location = new System.Drawing.Point(53, 21);
            this.radioButton1Age.Name = "radioButton1Age";
            this.radioButton1Age.Size = new System.Drawing.Size(58, 21);
            this.radioButton1Age.TabIndex = 4;
            this.radioButton1Age.TabStop = true;
            this.radioButton1Age.Text = "0-20";
            this.radioButton1Age.UseVisualStyleBackColor = true;
            // 
            // radioButton2Age
            // 
            this.radioButton2Age.AutoSize = true;
            this.radioButton2Age.Location = new System.Drawing.Point(53, 48);
            this.radioButton2Age.Name = "radioButton2Age";
            this.radioButton2Age.Size = new System.Drawing.Size(66, 21);
            this.radioButton2Age.TabIndex = 5;
            this.radioButton2Age.TabStop = true;
            this.radioButton2Age.Text = "21-49";
            this.radioButton2Age.UseVisualStyleBackColor = true;
            // 
            // radioButton3Age
            // 
            this.radioButton3Age.AutoSize = true;
            this.radioButton3Age.Location = new System.Drawing.Point(53, 75);
            this.radioButton3Age.Name = "radioButton3Age";
            this.radioButton3Age.Size = new System.Drawing.Size(50, 21);
            this.radioButton3Age.TabIndex = 6;
            this.radioButton3Age.TabStop = true;
            this.radioButton3Age.Text = "50-";
            this.radioButton3Age.UseVisualStyleBackColor = true;
            // 
            // checkBoxIceCream
            // 
            this.checkBoxIceCream.AutoSize = true;
            this.checkBoxIceCream.Location = new System.Drawing.Point(109, 101);
            this.checkBoxIceCream.Name = "checkBoxIceCream";
            this.checkBoxIceCream.Size = new System.Drawing.Size(123, 21);
            this.checkBoxIceCream.TabIndex = 7;
            this.checkBoxIceCream.Text = "I like ice cream";
            this.checkBoxIceCream.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(301, 422);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // listBoxCountry
            // 
            this.listBoxCountry.FormattingEnabled = true;
            this.listBoxCountry.ItemHeight = 16;
            this.listBoxCountry.Items.AddRange(new object[] {
            "Finland",
            "Sweden",
            "USA",
            "Norway"});
            this.listBoxCountry.Location = new System.Drawing.Point(56, 297);
            this.listBoxCountry.Name = "listBoxCountry";
            this.listBoxCountry.Size = new System.Drawing.Size(217, 68);
            this.listBoxCountry.TabIndex = 9;
            // 
            // groupBoxAge
            // 
            this.groupBoxAge.Controls.Add(this.radioButton1Age);
            this.groupBoxAge.Controls.Add(this.radioButton2Age);
            this.groupBoxAge.Controls.Add(this.radioButton3Age);
            this.groupBoxAge.Location = new System.Drawing.Point(56, 150);
            this.groupBoxAge.Name = "groupBoxAge";
            this.groupBoxAge.Size = new System.Drawing.Size(217, 113);
            this.groupBoxAge.TabIndex = 10;
            this.groupBoxAge.TabStop = false;
            this.groupBoxAge.Text = "My age is";
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(130, 61);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(143, 22);
            this.textBoxNickName.TabIndex = 11;
            // 
            // textBoxPrint
            // 
            this.textBoxPrint.Location = new System.Drawing.Point(56, 387);
            this.textBoxPrint.Multiline = true;
            this.textBoxPrint.Name = "textBoxPrint";
            this.textBoxPrint.Size = new System.Drawing.Size(217, 58);
            this.textBoxPrint.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 502);
            this.Controls.Add(this.textBoxPrint);
            this.Controls.Add(this.textBoxNickName);
            this.Controls.Add(this.groupBoxAge);
            this.Controls.Add(this.listBoxCountry);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.checkBoxIceCream);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNickName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAge.ResumeLayout(false);
            this.groupBoxAge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNickName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1Age;
        private System.Windows.Forms.RadioButton radioButton2Age;
        private System.Windows.Forms.RadioButton radioButton3Age;
        private System.Windows.Forms.CheckBox checkBoxIceCream;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ListBox listBoxCountry;
        private System.Windows.Forms.GroupBox groupBoxAge;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.TextBox textBoxPrint;
    }
}

