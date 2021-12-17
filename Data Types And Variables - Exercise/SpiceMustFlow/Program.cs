using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeld = int.Parse(Console.ReadLine());
            int daysCounter = 0;
            int totalProducedYeld = 0;

            if (startingYeld < 100)
            {
                Console.WriteLine($"{daysCounter}");
                Console.WriteLine($"{totalProducedYeld}");
                return;
                
            }
            
            while (startingYeld >= 100)
            {
                totalProducedYeld += startingYeld - 26;
                startingYeld -= 10;
                daysCounter++;
                
            }
            
            totalProducedYeld -= 26;
            Console.WriteLine($"{daysCounter}");
            Console.WriteLine($"{totalProducedYeld}");
        }
    }
}
