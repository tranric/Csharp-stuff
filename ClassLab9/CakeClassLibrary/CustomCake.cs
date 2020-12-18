using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClassLibrary
{
    public class CustomCake : Cake
    {
        private const byte CAKEPRICE = 10;
        private const byte LAYERPRICE = 3;
        private const byte SIZEPRICE = 1;

        private int intSize;
        private int intLayers;
        private string strFlavour;

        public int Size
        { get { return intSize; } set { intSize = value; } }

        public int Layers
        { get { return intLayers; } set { intLayers = value; } }

        public string Flavour
        { get { return strFlavour; } set { strFlavour = value; } }

        //version with different price for base cake other than the standard one
        public CustomCake(string flavour, int size, int layers, decimal price)
            : base(price)
        {
            this.strFlavour = flavour;
            this.Layers = layers;
            this.Size = size;
        }

        //assume price is the standard one
        public CustomCake(string flavour, int size, int layers)
            : base(CAKEPRICE)
        {
            this.strFlavour = flavour;
            this.Layers = layers;
            this.Size = size;
        }

        public CustomCake()
        {
        }

        public override decimal CalculateCost()
        {
            return ((Layers * LAYERPRICE) + (Size * SIZEPRICE) + Price);
        }
        public override string ToString()
        {
            return Flavour + " flavoured with " + Layers + " layer(s) " + Size + " inch size for " + CalculateCost().ToString("C2");
        }
    }
}
