namespace Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the number of pages");
            int numPages = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the due date (MM/DD/YYYY)");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the return date (MM/DD/YYYY)");
            DateTime returnedDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the days to read");
            int daysToRead = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the daily late fee rate");
            double dailyLateFeeRate = Convert.ToDouble(Console.ReadLine());

            Book book = new Book(title, author, numPages, dueDate, returnedDate);

            double avgPagesRead = book.AveragePagesReadPerDay(daysToRead);
            Console.WriteLine($"Average Pages Read Per Day : {Math.Round(avgPagesRead)}");

            double lateFee = book.CalculateLateFee(dailyLateFeeRate);
            Console.WriteLine($"Late Fee : {lateFee}");
        }
    }
}    

