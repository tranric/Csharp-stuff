using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClassLibrary
{
    public class SpecialCake : Cake
    {
        //public const decimal HOLIDAYCAKE = 18m;
        //public const decimal BIRTHDAYCAKE = 25m;
        //public const decimal WEDDINGCAKE = 40m;
        //public const decimal SUPERHEROCAKE = 30m;
        private string name;
        private string[] specialCakes = {"Holiday Cake", "Birthday Cake", "Wedding Cake", "SuperHero Cake"};
        private decimal[] prices = { 18, 25, 40, 30 };

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SpecialCake(string name)
            : base()
        {
            Name = name;
            for (int i = 0; i < specialCakes.Length; i++)
            {
                if (Name == specialCakes[i])
                {
                    Price = prices[i];
                }
            }
            //check for cake name and assign matching price
            //switch (Name)
            //{
            //    case "Holiday Cake":
            //        Price = HOLIDAYCAKE;
            //        break;
            //    case "Birthday Cake":
            //        Price = BIRTHDAYCAKE;
            //        break;
            //    case "Wedding Cake":
            //        Price = WEDDINGCAKE;
            //        break;
            //    case "Superhero Cake":
            //        Price = SUPERHEROCAKE;
            //        break;
            //}
        }

        public override string ToString()
        {
            return Name + " at price $" + CalculateCost();
        }
    }
}
