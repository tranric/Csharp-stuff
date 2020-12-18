using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Customer
    {
        private string strFirstName;
        private string strLastName;

        public string FirstName
        {
            get
            {
                return strFirstName;
            }
            set
            {
                strFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return strLastName;
            }
            set
            {
                strLastName = value;
            }
        }

        public Customer(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public override String ToString()
        {
            return "Thank you " + FirstName + " " + LastName + "!! " + Environment.NewLine;
        }

    }
}
