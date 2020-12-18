using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClassLibrary
{
    public class Customer
    {
        private string strFirstName;
        private string strLastName;
        private string straddress;
        private string strcity, strprovince, strpostal;

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

        public string Address
        {
            get
            {
                return straddress;
            }
            set
            {
                straddress = value;
            }
        }

        public string City
        {
            get
            {
                return strcity;
            }
            set
            {
                strcity = value;
            }
        }

        public string Province
        {
            get
            {
                return strprovince;
            }
            set
            {
                strprovince = value;
            }
        }

        public string Postal
        {
            get
            {
                return strpostal;
            }
            set
            {
                strpostal = value;
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

        public Customer(string fName, string lName, string address, string city, string province, string postal)
        {
            /*        private string straddress;
        private string strcity, strprovince, strpostal;*/
            FirstName = fName;
            LastName = lName;
            Address = address;
            City = city;
            Province = province;
            Postal = postal;
        }

        public Customer()
        {
        }

        public override String ToString()
        {
            return "Thank you " + FirstName + " " + LastName + "!! " + Environment.NewLine + Address + Environment.NewLine +
                City + Environment.NewLine + Province + Environment.NewLine + Postal + Environment.NewLine;
        }
    }
}
