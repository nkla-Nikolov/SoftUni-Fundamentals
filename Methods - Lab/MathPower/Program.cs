using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(Powered(number, power));
        }

        static double Powered (double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
