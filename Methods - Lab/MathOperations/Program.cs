using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            double result = GetCalculated(a, @operator, b);
            Console.WriteLine($"{result}");
        }

        static double GetCalculated(int a, string @operator, int b)
        {
            int result = 0;

            if (@operator == "/")
            {
                result = a / b;
            }
            else if (@operator == "*")
            {
                result = a * b;
            }
            else if (@operator == "+")
            {
                result = a + b;
            }
            else if (@operator == "-")
            {
                result = a - b;
            }

            return result;
        }
    }
}
