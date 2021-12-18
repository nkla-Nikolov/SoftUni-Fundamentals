using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEfficiency = int.Parse(Console.ReadLine());
            int secondEfficiency = int.Parse(Console.ReadLine());
            int thirdEfficiency = int.Parse(Console.ReadLine());
            int totalCountPeople = int.Parse(Console.ReadLine());

            int hour = 0;
            int totalPeoplePerHour = firstEfficiency + secondEfficiency + thirdEfficiency;

            while (totalCountPeople > 0)
            {
                
                totalCountPeople -= totalPeoplePerHour;
                hour++;

                if (hour % 4 == 0)
                {
                    hour++;
                }
            }

            
            Console.WriteLine($"Time needed: {hour}h.");

        }
    }
}
