using System;
using System.Linq;
using System.Numerics;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (GetMultiplication(num1, num2, num3) < 0)
            {
                Console.WriteLine("negative");
            }
            else if (GetMultiplication(num1, num2, num3) > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }

        static int GetMultiplication(int num1, int num2, int num3)
        {
            int result = num1 * num2 * num3;

            return result;
        }
    }
}


