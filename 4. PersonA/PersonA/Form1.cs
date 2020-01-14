using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonA
{
    public partial class Form1 : Form
    {
        string clearBox = "";
        string vali = "  ";
        private Persons[] persons = new Persons[10]; //array

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Persons objectPersons = new Persons();  //muodostetaan olio

            //Tallennetaan nimet ja ikä propertyihin
            objectPersons.PersonFirstName = textBoxLastName.Text;   
            objectPersons.PersonLastName = textBoxFirstName.Text;
            objectPersons.PersonAge = textBoxAge.Text;

            //lasketaan henkilöiden määrää
            persons[objectPersons.PersonNumber - 1] = objectPersons;

            //tyhjennetään textBoxit
            textBoxLastName.Text = clearBox;
            textBoxFirstName.Text = clearBox;
            textBoxAge.Text = clearBox;

            //button menee pois päältä 10 syötön jälkeen.
            if (Persons.personCounter >= 10) button1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBoxPrint.Text = clearBox;
            for (int i = 0; i < Persons.personCounter; i++)
            {
                //tulostus
                textBoxPrint.Text = textBoxPrint.Text +
                persons[i].PersonFirstName + vali +
                persons[i].PersonLastName + vali +
                persons[i].PersonAge + vali +
                Environment.NewLine;
            }
        }
    }
}
