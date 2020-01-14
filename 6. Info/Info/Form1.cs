using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string print;
        public string clear = "";
        public string vali = " ";
        public string PrintText()
        {
            //stringien nimeäminen
            string nickName = "";
            string iceCream = "";
            string age = "";
            string country = "";

            //TextBoxin arvo nickNameen.
            nickName = "Hi, my name is " + textBoxNickName.Text + ". ";

            //If-lause, jolla katsotaan jäätelön checkBox.
            if (checkBoxIceCream.Checked) { iceCream = "I like ice cream. "; }

            //If-lauseet radioButtoneille, ikä laitetaan age-stringille
            if (radioButton1Age.Checked) { age = "My age is 0-20"; }
            if (radioButton2Age.Checked) { age = "My age is 21-49"; }
            if (radioButton3Age.Checked) { age = "My age is 50-"; }

            //listBoxista tallennetaan valinta
            country = ". I like to live in " + listBoxCountry.GetItemText(listBoxCountry.SelectedItem);

            //tallennetaan kaikki print stringiin
            print = nickName + iceCream + age + country;

            return print;
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            PrintText();    //esitellään PrintText funktio
            textBoxPrint.Text = clear; //tyhjennetään textBox
            textBoxPrint.Text = print; //tulostetaan print string
        }
    }
}
