using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFirst = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arraySecond = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            bool isEqual = false;
            int sum = 0;

            for (int i = 0; i < arrayFirst.Length; i++)
            {
                sum += arrayFirst[i];
                for (int j = 0; j < arraySecond.Length; j++)
                {
                    if (arrayFirst[i] == arraySecond[i])
                    {
                        isEqual = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
