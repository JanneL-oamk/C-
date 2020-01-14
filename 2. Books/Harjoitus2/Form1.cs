using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Books oBooks1 = new Books(); //olio ilman parametrejä
            Books oBooks2 = new Books("Kalle Anka", 6.50); //olio kahdella parametrillä
            Books oBooks3 = new Books("Roope Ankka"); //olio yhdellä parametrillä

            oBooks1.setName("Aku Ankka"); //asetetaan olio 1 nimitieto
            oBooks1.setPrice(5.99); //asetetaan olio 1 hintatieto

            oBooks3.setPrice(12.99); //asetetaan olio 3 hintatieto

            textBox1.Text = oBooks1.getName() + " " + oBooks1.getPrice() + "$"; //olio 1 print textbox1
            textBox2.Text = oBooks2.getName() + " " + oBooks2.getPrice() + "$"; //olio 2 print textbox2
            textBox3.Text = oBooks3.getName() + " " + oBooks3.getPrice() + "$"; //olio 3 print textbox3
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}

class Books
{
    private string sBook; //määritetään muuttuja kirjalle
    private double sPrice; //määritetään muuttuja hinnalle

    public Books()
    {
        //parametriton muodostin
    }
    
    public Books(string bookName)
    {
        //yhdellä parametrillä muodostin
        sBook = bookName; //saadaan kirjan nimi parametristä
    }

    public Books(string bName, double bPrice)
    {
        //kahdella parametrillä muodostin
        sBook = bName; //saadaan kirjan nimi 
        sPrice = bPrice; //ja hinta parametristä
    }

    public void setName(string bookName)
    {
        sBook = bookName; //asetetaan parametrillä nimi
    }

    public string getName()
    {
        return sBook; //palautetaan kirjan nimi
    }

    public void setPrice(double bookPrice)
    {
        sPrice = bookPrice; //asetetaan parametrillä hinta
    }

    public double getPrice()
    {
        return sPrice; //palautetaan kirjan hinta
    }
}
