using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    public class Candy
    {
        public string Flavour { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double DiscountedPrice { get; set; }

        public bool ValidateCandyFlavour()
        {
            return Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint";
        }
    }
}

