namespace Q18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("1. Price Without Discount");
            Console.WriteLine("2. Price With Discount");
            Console.WriteLine("Enter the choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) // Calculate price without discount
            {
                decimal totalPrice = product.CalculateTotalPrice(price, quantity);
                Console.WriteLine($"Total price without discount {totalPrice}");
            }
            else if (choice == 2) // Calculate price with discount
            {
                Console.WriteLine("Enter the discount percentage");
                int discountPercentage = Convert.ToInt32(Console.ReadLine());

                decimal totalPriceWithDiscount = product.CalculateTotalPrice(price, quantity, discountPercentage);
                Console.WriteLine($"Total price with discount {totalPriceWithDiscount}");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

    }
}

