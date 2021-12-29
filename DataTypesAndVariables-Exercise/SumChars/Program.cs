using System;

namespace SumChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfInput; i++)
            {
                char charecters = char.Parse(Console.ReadLine());
                sum += charecters;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
