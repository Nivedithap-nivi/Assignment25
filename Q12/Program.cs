namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total cost");
            double totalCost = Convert.ToDouble(Console.ReadLine());

            object boxedTotalCost = totalCost;

            object discountedPrice = CalculateDiscountedPrice(boxedTotalCost);

            double finalPrice = (double)discountedPrice;
            Console.WriteLine($"Price after discount is {finalPrice}");
        }

        public static object CalculateDiscountedPrice(object totalCost)
        {
            double cost = (double)totalCost;
            double discount = 0;

            if (cost >= 100 && cost <= 500)
            {
                discount = 0.05 * cost;
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = 0.15 * cost;
            }
            else if (cost > 1000)
            {
                discount = 0.30 * cost;
            }

            double discountedPrice = cost - discount;

            return (object)discountedPrice;
        }
    }
    
}
