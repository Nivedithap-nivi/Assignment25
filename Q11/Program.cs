namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            int[][] points = new int[numberOfStudents][];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter the number of competitions attended by student {i + 1}");
                int numCompetitions = Convert.ToInt32(Console.ReadLine());

                points[i] = new int[numCompetitions];

                Console.WriteLine($"Enter the student {i + 1} points");
                for (int j = 0; j < numCompetitions; j++)
                {
                    points[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            string result = FindWhoGotMaximumPoints(points);
            Console.WriteLine(result);
        }

        public static string FindWhoGotMaximumPoints(int[][] points)
        {
            int maxPoints = 0;
            int studentIndex = -1;

            for (int i = 0; i < points.Length; i++)
            {
                int totalPoints = 0;
                foreach (int score in points[i])
                {
                    totalPoints += score;
                }

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    studentIndex = i;
                }
            }

            return $"Student {studentIndex + 1} got maximum points";
        }
    }
    
}
