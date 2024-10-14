namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the string:");
                string input = Console.ReadLine();

                string[] words = input.Split(':');

                if (words.Length > 15)
                {
                    Console.WriteLine("Invalid length");
                }
                else
                {
                    Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                    foreach (string word in words)
                    {
                        string upperWord = word.ToUpper();
                        if (wordCount.ContainsKey(upperWord))
                        {
                            wordCount[upperWord]++;
                        }
                        else
                        {
                            wordCount[upperWord] = 1;
                        }
                    }

                    foreach (var item in wordCount)
                    {
                        Console.WriteLine($"{item.Key}:{item.Value}");
                    }
                }
            }
        }
    }
}
