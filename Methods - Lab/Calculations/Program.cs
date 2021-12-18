using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCalculation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (typeCalculation == "add")
            {
                Add(num1, num2);
            }
            else if (typeCalculation == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (typeCalculation == "subtract")
            {
                Subtract(num1, num2);
            }
            else if (typeCalculation == "divide")
            {
                Divide(num1, num2);
            }
        }

        static void Add (int num, int num2)
        {
            Console.WriteLine(num + num2);
        }

        static void Multiply(int num, int num2)
        {
            Console.WriteLine(num * num2);
        }

        static void Subtract(int num, int num2)
        {
            Console.WriteLine(num - num2);
        }

        static void Divide(int num, int num2)
        {
            Console.WriteLine(num / num2);
        }
    }
}
