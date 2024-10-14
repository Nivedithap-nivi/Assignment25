namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += char.ToUpper(input[i]);
                }
                else
                {
                    result += char.ToLower(input[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
    
}
