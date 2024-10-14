namespace Q17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Desktop\n2. Laptop");
            Console.WriteLine("Choose the option");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                Desktop desktop = new Desktop();

                Console.WriteLine("Enter the processor");
                desktop.Processor = Console.ReadLine();

                Console.WriteLine("Enter the ram size");
                desktop.RamSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the hard disk size");
                desktop.HardDiskSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the graphic card size");
                desktop.GraphicCard = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the monitor size");
                desktop.MonitorSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the power supply volt");
                desktop.PowerSupplyVolt = Convert.ToInt32(Console.ReadLine());


                double desktopPrice = desktop.DesktopPriceCalculation();
                Console.WriteLine($"Desktop price is {desktopPrice}");
            }
            else if (choice == 2)
            {
                Laptop laptop = new Laptop();

                Console.WriteLine("Enter the processor");
                laptop.Processor = Console.ReadLine();

                Console.WriteLine("Enter the ram size");
                laptop.RamSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the hard disk size");
                laptop.HardDiskSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the graphic card size");
                laptop.GraphicCard = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the display size");
                laptop.DisplaySize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the battery volt");
                laptop.BatteryVolt = Convert.ToInt32(Console.ReadLine());

                double laptopPrice = laptop.LaptopPriceCalculation();
                Console.WriteLine($"Laptop price is {laptopPrice}");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
