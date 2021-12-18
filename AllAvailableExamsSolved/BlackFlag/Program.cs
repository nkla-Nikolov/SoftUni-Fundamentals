using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double plunderPerDay = double.Parse(Console.ReadLine());
            int expectedPlunder = int.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plunderPerDay;

                if (i % 3 == 0)
                {
                    totalPlunder += plunderPerDay * 0.50;
                }

                if (i % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.30;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {totalPlunder / expectedPlunder * 100:f2}% of the plunder.");
            }
        }
    }
}
