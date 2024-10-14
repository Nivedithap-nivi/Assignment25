namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer value: ");
            int intValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a float value: ");
            float floatValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a double value: ");
            double doubleValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a long value: ");
            long longValue = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter a string value: ");
            string stringValue = Console.ReadLine();

            Console.WriteLine($"int : {intValue}");
            Console.WriteLine($"float : {floatValue}");
            Console.WriteLine($"double : {doubleValue}");
            Console.WriteLine($"long : {longValue}");
            Console.WriteLine($"string : {stringValue}");
        }
    }
}
    

