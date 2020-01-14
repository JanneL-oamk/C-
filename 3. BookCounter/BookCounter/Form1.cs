using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCounter
{
    public partial class Form1 : Form
    {
        string clearBox = "";
        string vali = ",  ";
        public const int MAX_BOOK = 100; //maksimi kirjamäärä
        private Book[] bookArray = new Book[MAX_BOOK]; //array

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Book objectBook = new Book();   //Luodaan olio
            objectBook.BookName = textBox1.Text;    //Kirjan nimi tulee ekasta textboxista
            objectBook.BookAuthor = textBox2.Text;  //Kirjailijan nimi tulee tokasta textboxista
            bookArray[objectBook.BookNumber - 1] = objectBook;  //Kirjan numero
            textBox1.Text = clearBox;   //tyhjennetään, kun¨clickataan            
            textBox2.Text = clearBox;   //tyhjennetään, kun clickataan
            if (Book.bookCounter >= MAX_BOOK) button1.Enabled = false; //H5T1 selitetty
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = clearBox; 
            for (int i = 0; i < Book.bookCounter; i++) //printataan kirjoja, kuinka paljon niitä on
            {
                textBox3.Text = textBox3.Text +     //printtaa myös edelliset rivit
                    bookArray[i].BookNumber + vali + //kirjan numero
                    bookArray[i].BookName + vali +  //kirjan nimi
                    bookArray[i].BookAuthor +       //kirjailijan nii 
                    Environment.NewLine;            //rivinvaihto
            }
        }
    }
}
