using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(daysOfWeek[n - 1]);
        }
    }
}
