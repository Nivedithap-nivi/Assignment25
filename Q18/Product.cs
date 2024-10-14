using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
    public class Product
    {
        public decimal CalculateTotalPrice(decimal price, int quantity)
        {
            return price * quantity;
        }
        public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
        {
            decimal totalPrice = price * quantity;
            decimal discountAmount = totalPrice * discountPercentage / 100;
            return totalPrice - discountAmount;
        }
    }

}

