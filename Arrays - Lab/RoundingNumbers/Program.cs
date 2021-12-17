using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = 0;
                }
                
                double rounded = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {rounded}");
            }
        }
    }
}
