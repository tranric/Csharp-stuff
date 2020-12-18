using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Order
    {
        public const decimal TAX = 0.13m;
        private int intNumOfCakes;
        private Customer customer;
        private Cake cake;
        private List<Cake> cakelist;


        //confirmation number for order
        //generated when order accepted
        private int confirmationNumber;
        //generate random number
        Random rndClass = new Random();

        public Customer Customer
        {
            get{ return customer;}
            set{ customer = value;}
        }

        public Cake Cake
        {
            get
            {
                return cake;
            }
            set
            {
                cake = value;
            }
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

        //no set needed for confirmation number, it's generated here
        public int ConfirmationNumber
        {
            get
            {
                return //randomize number between 1000 and 10000
                confirmationNumber = rndClass.Next(1000, 10000);
            }
        }
        public Order()
        {
            //cake = new Cake();
            //customer = new Customer(fName,lName);
            cakelist = new List<Cake>();
        }

        public Order(Customer customer, int numOfCakes)
        {
            Customer = customer;
           
            Cake = new Cake();
            cakelist = new List<Cake>();
            NumOfCakes = numOfCakes;
        }

        public Order(string fName, string lName, int numOfCakes)
        {
            Customer = new Customer(fName, lName);
            
            Cake = new Cake();
            cakelist = new List<Cake>();
            NumOfCakes = numOfCakes;
        }

        //customer cake version with price different from standard price
        public Order(string fName, string lName, string flavour, int size, int layers, decimal price)
        {
            Customer = new Customer(fName, lName);
            cake = new CustomCake(flavour, size, layers, price);
            // NumOfCakes = 1;   
            cakelist = new List<Cake>();
            NumOfCakes = cakelist.Count;
        }

        //custom cake version using standard pricing
        public Order(string fName, string lName, string flavour, int size, int layers)
        {
            Customer = new Customer(fName, lName);
            cake = new CustomCake(flavour, size, layers);
            cakelist = new List<Cake>();
            NumOfCakes = cakelist.Count;
        }

        //special cake
        public Order(string fName, string lName, string name)
        {
            Customer = new Customer(fName, lName); 
            cake = new SpecialCake(name);
            cakelist = new List<Cake>();
            NumOfCakes = cakelist.Count;
        }
        public decimal CalculateTotal()
        {
         //   return NumOfCakes * Cake.CalculateCost() * (1 + TAX);
            decimal totalprice = 0;
         //   int counter = cakelist.Count;
            for (int i = 0; i < cakelist.Count; i++)
            {
                totalprice = cakelist.Count * cakelist[i].CalculateCost();
            }
            return totalprice * (1 + TAX);
        }

        public void clearcart()
        {
            cakelist.Clear();
        }

        public void AddCake(String flavour, int size, int layers)
        {
            cake = new CustomCake(flavour, size, layers);
            cakelist.Add(cake);
            
        }
/*
        public void AddSpecialCake(lstSC)
        {
            cake = new SpecialCake(lstSC);
            cakelist.Add(cake);
        }*/

        public void AddCake(string name)
        {
            cakelist.Add(new SpecialCake(name));
          
        }


        public override string ToString()
        {
          /*  string result = "";
            result += "The number of items are: " + refrigerators.Count + Environment.NewLine + "The details are : " + Environment.NewLine;
            for (int i = 0; i < refrigerators.Count; i++)
            {
                result += refrigerators[i].ToString() + Environment.NewLine;
            }
            MessageBox.Show(result);
           */ string result = "";
              result = customer.ToString() + "\nYou have ordered " + cakelist.Count + " cake(s) - ";
            for (int i = 0; i < cakelist.Count; i++)
            {
                result += Environment.NewLine + cakelist[i].ToString();
                    
            }
            result += Environment.NewLine + " for the total cost of " + CalculateTotal().ToString("c");  //String.Format("{0:c}",CalculateTotal());
      

            return result;
         //  return customer.ToString() + "\nYou have ordered " + NumOfCakes + " cake(s) " + Cake.ToString() +
         //           " for the total cost of " + CalculateTotal().ToString("c");  //String.Format("{0:c}",CalculateTotal());
        }

        public string Confirmation()
        {
            //confirmation number to string method
            return Customer.ToString() + "Your order has been placed."
                + Environment.NewLine + "Your Confirmation Code is : " + ConfirmationNumber;
        }
    }
}
