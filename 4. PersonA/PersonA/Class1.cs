using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonA
{
    class Persons
    {

        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonAge { get; set; }

        public int PersonNumber;

        public static int personCounter = 0;
        public Persons()
        {
            personCounter++;
            PersonNumber = personCounter;
        }
    }
}
