namespace Q14
{
   public class Program
    {
            public Candy CalculateDiscountedPrice(Candy candy)
            {
                candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

                double discountPercentage = candy.Flavour switch
                {
                    "Strawberry" => 15,
                    "Lemon" => 10,
                    "Mint" => 5,
                    _ => 0
                };

                candy.DiscountedPrice = candy.TotalPrice - (candy.TotalPrice * discountPercentage / 100);
                return candy;
            }

            public static void Main(string[] args)
            {
                Program program = new Program();

                Console.WriteLine("Enter the flavour:");
                string flavour = Console.ReadLine();

                Console.WriteLine("Enter the quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the price per piece:");
                int pricePerPiece = Convert.ToInt32(Console.ReadLine());

                Candy candy = new Candy
                {
                    Flavour = flavour,
                    Quantity = quantity,
                    PricePerPiece = pricePerPiece
                };

                if (!candy.ValidateCandyFlavour())
                {
                    Console.WriteLine("Invalid flavour");
                    return;
                }

                candy = program.CalculateDiscountedPrice(candy);

                Console.WriteLine($"Flavour : {candy.Flavour}");
                Console.WriteLine($"Quantity : {candy.Quantity}");
                Console.WriteLine($"Price Per Piece : {candy.PricePerPiece}");
                Console.WriteLine($"Total Price : {candy.TotalPrice}");
                Console.WriteLine($"Discount Price : {candy.DiscountedPrice}");
            }

        
    }
}
