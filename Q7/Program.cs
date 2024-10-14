using System.Text;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static StringBuilder FindExponential(int number)
            {
                StringBuilder result = new StringBuilder("Exponential is ");

                string exponential = Math.Pow(number, 2).ToString("E6");

                result.Append(exponential);

                return result;
            }

            static StringBuilder ReplaceWord(string sentence, string word1, string word2)
            {
                StringBuilder result = new StringBuilder(sentence);

                result.Replace(word1, word2);

                return result;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("1. Find Exponential");
                Console.WriteLine("2. Replace Word");
                Console.WriteLine("Choose the option:");

                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the number:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    StringBuilder exponentialResult = FindExponential(number);
                    Console.WriteLine(exponentialResult);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter a sentence:");
                    string sentence = Console.ReadLine();

                    Console.WriteLine("Enter the word to be replaced:");
                    string word1 = Console.ReadLine();

                    Console.WriteLine("Enter the word to replace with:");
                    string word2 = Console.ReadLine();

                    StringBuilder replaceResult = ReplaceWord(sentence, word1, word2);
                    Console.WriteLine(replaceResult);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose 1 or 2.");
                }
            }

        }
    }
    
}
