using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(firstNum, secondNum, thirdNum));
        }

        static int Sum(int n1, int n2)
        {
            return n1 += n2;
        }

        static int Subtract(int num1, int num2, int num3)
        {
            return Sum(num1, num2) - num3;
        }
    }
}
