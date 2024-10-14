using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public virtual double CalculateCost(double basePrice, int currentYear)
        {
            return basePrice;
        }
    }

    public class SportsCar : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        {
            int age = currentYear - Year;
            double taxRate = 0.10;
            double totalTax = basePrice * taxRate * age;
            return basePrice + totalTax;
        }
    }

    public class SUV : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        {
            int age = currentYear - Year;
            double taxRate = 0.05;
            double totalTax = basePrice * taxRate * age;
            return basePrice + totalTax;
        }
    }
}
