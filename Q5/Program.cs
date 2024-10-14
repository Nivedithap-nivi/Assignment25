using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace Q5
{
    public class Program
    {
        static StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            int index = word1.ToString().IndexOf(ch);

            if (index != -1)
            {
                word1.Insert(index, word2);
            }

            return word1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word 1");
            StringBuilder word1 = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Enter the character to search");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the word 2");
            string word2 = Console.ReadLine();

            StringBuilder result = WordInserting(word1, ch, word2);
            Console.WriteLine(result);
        }

    }
    
    
}

    

    

