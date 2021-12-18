using System;

namespace SignOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            IsPositive(num);
        }

        static void IsPositive (int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number 0 is zero.");
            }
        }
    }
}
