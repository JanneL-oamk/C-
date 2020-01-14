using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfWinProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            string result1 = "You won a new boat!!!";
            string result2 = "You won 1000$";
            string result3 = "You won a house!";
            string result4 = "Unknown selection";
            string inPutVal = textBox1.Text;

            int parsedInPutVal = int.Parse(inPutVal);

            if (int.Parse(inPutVal) == 1) //jos value = 1, tulostaa se tuloksen 1
            {
                resultLabel.Text = result1; 
            }
            else if(parsedInPutVal == 2) //jos value = 2, tulostaa se tuloksen 2
            {
                resultLabel.Text = result2;
            }
            else if(parsedInPutVal == 3) //jos value = 3, tulostaa se tuloksen 3
            {
                resultLabel.Text = result3;
            }
            else                         //jos value on jokin muu, se tulostaa tuloksen 4
            {
                resultLabel.Text = result4;
            }
        }
    }
}
