namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Movie name: ");
            string movieName = Console.ReadLine();

            Console.WriteLine("Enter the Ticket id: ");
            int movieTicketId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Movie seat number: ");
            string movieSeatNumber = Console.ReadLine();

            Q2movie movie = new Q2movie();
            Q2movie movieDetails = movie.ReturnMovieDetails(movieName, movieTicketId, movieSeatNumber);

            Console.WriteLine("Movie Name: " + Q2movie.name);
            Console.WriteLine("Ticket ID: " + movieDetails.ticketId);
            Console.WriteLine("Seat Number: " + movieDetails.seatNumber);
        }
    }
}
    

