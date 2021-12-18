using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> sum = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                sum.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }
            
            if (numbers.Count % 2 != 0)
            {
                sum.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
