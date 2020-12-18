using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class SpecialCake : Cake
    {
        public const decimal HOLIDAYCAKE = 18m;
        public const decimal BIRTHDAYCAKE = 25m;
        public const decimal WEDDINGCAKE = 40m;
        public const decimal SUPERHEROCAKE = 30m;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SpecialCake(string name)
            : base()
        {
            Name = name;
            //check for cake name and assign matching price
            switch (Name)
            {
                case "Holiday Cake":
                    Price = HOLIDAYCAKE;
                    break;
                case "Birthday Cake":
                    Price = BIRTHDAYCAKE;
                    break;
                case "Wedding Cake":
                    Price = WEDDINGCAKE;
                    break;
                case "Superhero Cake":
                    Price = SUPERHEROCAKE;
                    break;
            }
        }

        public override string ToString()
        {
            return Name + " at price $" + CalculateCost();
        }
    }
}
