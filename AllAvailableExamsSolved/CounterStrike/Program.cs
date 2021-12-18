using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int battlesWon = 0;

            while (command != "End of battle")
            {
                if (energy <= 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    return;
                }

                int distance = int.Parse(command);

                if (battlesWon % 3 == 0)
                {
                    energy += battlesWon;
                }

                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    return;
                }

                energy -= distance;
                battlesWon++;

                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
        }
    }
}
