using System;

namespace Taenkhun_Thunkheam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score (0-100): ");
            string input = Console.ReadLine();

            int score;
            if (!int.TryParse(input, out score) || score < 0 || score > 100)
            {
                Console.WriteLine("Invalid input. Please enter an integer between 0 and 100.");
                return;
            }

            Console.WriteLine(GetGrade(score));
        }

        private static string GetGrade(int score)
        {
            if (score >= 80) return "Grade A";
            if (score >= 75) return "Grade B+";
            if (score >= 70) return "Grade B";
            if (score >= 65) return "Grade C+";
            if (score >= 60) return "Grade C";
            if (score >= 55) return "Grade D+";
            if (score >= 50) return "Grade D";
            return "Grade F";
        }
    }
}
