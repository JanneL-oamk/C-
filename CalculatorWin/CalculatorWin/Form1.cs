using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            double sum = double.Parse(value1) + double.Parse(value2);
            resultLabel.Text = "Result is: " + sum.ToString();
        }

        private void EroButton_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            double dif = double.Parse(value1) - double.Parse(value2);
            resultLabel.Text = "Result is: " + dif.ToString();
        }

        private void KertoButton_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            double mul = double.Parse(value1) * double.Parse(value2);
            resultLabel.Text = "Result is: " + mul.ToString();
        }

        private void JakoButton_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            double div = double.Parse(value1) / double.Parse(value2);
            resultLabel.Text = "Result is: " + div.ToString();
        }
    }
}
