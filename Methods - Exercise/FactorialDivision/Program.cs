using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result = Factorial(firstNum) / Factorial2(secondNum);
            Console.WriteLine($"{result:f2}");

        }

        static double Factorial(double num1)
        {
            double factor = 1;
            for (int i = 1; i <= num1; i++)
            {
                factor *= i;
            }

            return factor;
        }

        static double Factorial2(double num2)
        {
            double factor = 1;
            for (int i = 1; i <= num2; i++)
            {
                factor *= i;
            }

            return factor;
        }
    }
}
