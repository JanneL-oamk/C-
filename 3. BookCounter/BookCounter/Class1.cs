using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Book
    {
        // properties

        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int BookNumber { get; set; }

        //Staattinen kirjan lukumäärän laskija
        public static int bookCounter = 0;

    public Book()
        {
            //lisää kirjan ja antaa sen arvon BookNumber-propertylle
            bookCounter++;
            BookNumber = bookCounter;
        }
    }

