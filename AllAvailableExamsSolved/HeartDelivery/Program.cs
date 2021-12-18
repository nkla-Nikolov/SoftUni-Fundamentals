using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int currentPosition = 0;

            while (command != "Love!")
            {
                string[] jump = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                if (jump[0] == "Jump")
                {
                    currentPosition += int.Parse(jump[1]);
                }

                if (currentPosition >= houses.Count)
                {
                    currentPosition = 0;
                }

                if (houses[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }
                else
                {
                    houses[currentPosition] -= 2;

                    if (houses[currentPosition] == 0)
                    {
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentPosition}.");

            int counter = houses.Count(x => x != 0);
            if (houses.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
