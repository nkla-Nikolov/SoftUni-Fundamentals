using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers);

            if (numbers.Length < 3)
            {
                Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x)));
                return;
            }

            for (int i = numbers.Length - 1; i >= numbers.Length - 3; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
