namespace Q19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sports car");
            Console.WriteLine("2. SUV car");
            Console.WriteLine("3. None of the above");
            Console.WriteLine("Choose the option");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the make");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the model");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the year the car was made");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the base price");
            double basePrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the current year");
            int currentYear = Convert.ToInt32(Console.ReadLine());

            Car car;

            if (choice == 1)
            {
                car = new SportsCar();
                car.Make = make;
                car.Model = model;
                car.Year = year;
                double totalCost = car.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"Sports car cost is {totalCost}");
            }
            else if (choice == 2)
            {
                car = new SUV();
                car.Make = make;
                car.Model = model;
                car.Year = year;
                double totalCost = car.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"SUV car cost is {totalCost}");
            }
            else if (choice == 3)
            {
                car = new Car();
                car.Make = make;
                car.Model = model;
                car.Year = year;
                double totalCost = car.CalculateCost(basePrice, currentYear);
                Console.WriteLine($"The cost is {totalCost}");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
    
}
