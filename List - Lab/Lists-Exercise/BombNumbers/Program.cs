using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] arguments = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNum = arguments[0];
            int power = arguments[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNum)
                {
                    for (int j = i - power; j <= i + power; j++)
                    {
                        if (j < 0 || j >= numbers.Count)
                        {
                            continue;
                        }

                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
