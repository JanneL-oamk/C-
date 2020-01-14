using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        //Tulostaa MouseMove, kun hiiri on formilla
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "MouseMove";
        }

        //Tulostaa MouseEnter, kun hiiri on panelilla
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "MouseEnter";
        }

        //Tulostaa Button1 MouseEnter, kun hiiri on buttonilla
        private void jButton_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "Button1 MouseEnter";
        }

        //Tulostaa "You pressed the button", kun painaa buttonia
        private void JButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "You pressed the button";
        }
    }
}
