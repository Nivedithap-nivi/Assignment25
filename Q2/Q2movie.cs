using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Q2movie
    {
        public static string name;

        public int ticketId;
        public string seatNumber;

        public Q2movie ReturnMovieDetails(string name, int ticketId, string seatNumber)
        {
            Q2movie movie = new Q2movie();

            Q2movie.name = name;
            movie.ticketId = ticketId;
            movie.seatNumber = seatNumber;

            return movie;
        }
    }
}

