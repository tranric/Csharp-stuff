using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClassLibrary
{
    public class Order
    {
        public const decimal TAX = 0.13m;
        private int intNumOfCakes;
        private Customer customer;
        private List<Cake> cakeList; 

        //confirmation number for order
        //generated when order accepted
        private int confirmationNumber;
        //generate random number
        Random rndClass = new Random();

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public int NumOfCakes
        {
            get
            {
                return intNumOfCakes;
            }
            set
            {
                intNumOfCakes = value;
            }
        }

        public List<Cake> CakeList
        {
            get { return cakeList; }
            set { cakeList = value; }
        }

        //no set needed for confirmation number, it's generated here
        public int ConfirmationNumber
        {
            get
            {
                return //randomize number between 1000 and 10000
                confirmationNumber = rndClass.Next(1000, 10000);
            }
            set
            {
                confirmationNumber = value;
            }
        }

       /* 
         * other way of intializing cake list. Intialized cakelist in Order() and parameterized Order constructor uses it 
         * by calling Order() using this().
         */
        public Order()
        {
            cakeList = new List<Cake>();
            customer = new Customer();
            NumOfCakes = 1;
            ConfirmationNumber = 0;
        }
       
       
        //custom cake version
        public Order(string flavour, int size, int layers)
        {
            //initialize cakelist before using it
            cakeList = new List<Cake>();
            //CakeList.Add(new CustomCake(flavour, size, layers));
        }

       //special cake
        public Order(string name)
        {
            cakeList = new List<Cake>();
            //CakeList.Add(new SpecialCake(name));
        }

        public void AddCake(string flavour, int size, int layers)
        {
            //add custom cake to list
            CakeList.Add(new CustomCake(flavour, size, layers));
        }

        public void AddCake(string name)
        {
            CakeList.Add(new SpecialCake(name));
        }

        public void ClearCakeList()
        {
            CakeList.Clear();
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Cake cake in CakeList)
            {
                total += cake.CalculateCost();
            }
            return total * (1 + TAX);
        }

        public override string ToString()
        {
            string result = "";
            result += customer.ToString() + "\nYou have ordered " + CakeList.Count + " cake(s) " + Environment.NewLine; 
            foreach (Cake cake in CakeList)
            {
                result += cake.ToString() + Environment.NewLine;
            } 
                //Cake.ToString() +
             result += " for the total cost of " + CalculateTotal().ToString("c");
            return result;
        }

        public string Confirmation()
        {
            //confirmation number to string method
            return Customer.ToString() + "Your order has been placed."
                + Environment.NewLine + "Your Confirmation Code is : " + ConfirmationNumber;
        }
    }
}
