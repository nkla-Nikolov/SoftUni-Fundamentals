using System;

namespace SmallestOfThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallest(firstNum, secondNum, thirdNum));
        }

        static int GetSmallest(int number1, int number2, int number3)
        {
            int smallest = Math.Min(number1, Math.Min(number2, number3));

            return smallest;
        }
    }
}
