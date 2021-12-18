using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();
            bool isGoing = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] namesToAdd = input.Split();
                names.Add(namesToAdd[0]);

                if (namesToAdd[0] == )
                {
                    Console.WriteLine($"{namesToAdd[0]} is already in the list!");
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
