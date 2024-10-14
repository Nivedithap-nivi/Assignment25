namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            string[] products = new string[numberOfProducts];

            Console.WriteLine("Enter the product details");
            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the product id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the amount to update");
            double amount = Convert.ToDouble(Console.ReadLine());

            string result = UpdatePrice(products, id, amount);

            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public static string UpdatePrice(string[] details, int id, double amount)
        {
            for (int i = 0; i < details.Length; i++)
            {
                string[] productInfo = details[i].Split(':');

                if (Convert.ToInt32(productInfo[0]) == id)
                {
                    productInfo[2] = amount.ToString();

                    return $"{productInfo[1]} {productInfo[2]}";
                }
            }

            return string.Empty;
        }
    }
}
    

