using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmplyee = int.Parse(Console.ReadLine());
            int thirdEmplyee = int.Parse(Console.ReadLine());
            int totalCountPeople = int.Parse(Console.ReadLine());

            int hours = 0;
            int totalPeoplePerHour = firstEmployee + secondEmplyee + thirdEmplyee;

            while (totalCountPeople > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                
                totalCountPeople -= totalPeoplePerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
