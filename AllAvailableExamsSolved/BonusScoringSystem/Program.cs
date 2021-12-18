using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double countStudents = double.Parse(Console.ReadLine());
            double countLectures = double.Parse(Console.ReadLine());
            double bonusScore = double.Parse(Console.ReadLine());
            double studentMaxBonus = int.MinValue;
            double maxattendacies = int.MinValue;

            for (int i = 0; i < countStudents; i++)
            {
                double countOfAttendacies = double.Parse(Console.ReadLine());
                double temp = Math.Ceiling(countOfAttendacies / countLectures * (5 + bonusScore));

                if (temp > studentMaxBonus)
                {
                    studentMaxBonus = temp;
                    maxattendacies = countOfAttendacies;
                }
            }

            Console.WriteLine($"Max Bonus: {studentMaxBonus}.");
            Console.WriteLine($"The student has attended {maxattendacies} lectures.");


        }
    }
}
