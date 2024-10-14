namespace Q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the array size");
            int size = Convert.ToInt32(Console.ReadLine());

            char[] chars = new char[size];

            Console.WriteLine("Enter the characters");
            for (int i = 0; i < size; i++)
            {
                chars[i] = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Move to the next line for the next input
            }

            Console.WriteLine("Enter the special character");
            char specialChar = Console.ReadKey().KeyChar;

            program.ReplaceDuplicateWithSpecialChar(ref chars, specialChar);

            Console.WriteLine("Updated characters:");
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }

        public void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            HashSet<char> seenChars = new HashSet<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (seenChars.Contains(chars[i]))
                {
                    chars[i] = specialChar;
                }
                else
                {
                    seenChars.Add(chars[i]);
                }
            }
        }
    }
    
}
