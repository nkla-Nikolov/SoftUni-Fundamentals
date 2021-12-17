using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kms = meters * 0.001;

            Console.WriteLine($"{kms:f2}");
        }
    }
}
