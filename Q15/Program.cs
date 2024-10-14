namespace Q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Enter the owner name:");
            string ownerName = Console.ReadLine();

            Console.WriteLine("Enter the car body style:");
            string bodyStyle = Console.ReadLine();

            Console.WriteLine("Enter the price:");
            double price = Convert.ToDouble(Console.ReadLine());

            car.price = price;
            car.BodyStyle = bodyStyle;

            if (!car.ValidateBodyStyle(bodyStyle))
            {
                Console.WriteLine("Invalid Car Type");
            }
            else
            {
                double finalPrice = car.CalculatePrice();
                car.SetOwnerName(ownerName);

                Console.WriteLine($"The owner sells the {bodyStyle} type car for ${finalPrice}");
            }
        }
    }
}
    

