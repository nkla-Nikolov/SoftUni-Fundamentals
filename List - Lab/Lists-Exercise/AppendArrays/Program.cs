using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split("|")
                .ToArray();

            List<string> result = new List<string>();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                string[] subNumbers = numbers[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(subNumbers);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
