namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 11 2");

            int i = 2;

            do
            {
                int j = 1;

                do
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                }
                while (j <= 2);

                i++;
            } while (i <= 5);
        }
    }

}
    

