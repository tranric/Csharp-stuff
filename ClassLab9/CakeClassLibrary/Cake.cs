using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClassLibrary
{
    public class Cake
    {
        public const decimal STANDARD_PRICE = 20;
        private decimal decPrice;

        public decimal Price
        {
            get
            {
                return decPrice;
            }
            set
            {
                decPrice = value;
            }
        }

        public Cake(decimal price)
        {
            Price = price;
        }

        public Cake()
        {
            Price = STANDARD_PRICE;
        }

        public virtual decimal CalculateCost()
        {
            return Price;
        }
    }
}
