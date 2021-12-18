using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double flourPackage = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int freeFlour = (int)students / 5;
            
            //for (int i = 0; i < students; i++)
            //{
            //    if (students % 5 == 0)
            //    {
            //        freeFlour++;
            //    }
            //}

            double totalFlour = flourPackage * (students - freeFlour);
            double totalEggs = students * (eggPrice * 10);
            double totalApron = Math.Ceiling(students * 1.20) * apronPrice;
            double totalMoney = totalApron + totalEggs + totalFlour;

            if (totalMoney <= budget)
            {
                Console.WriteLine($"Items purchased for {totalMoney:f2}$.");
            }
            else
            {
                Console.WriteLine($"{totalMoney - budget:f2}$ more needed.");
            }
        }
    }
}
