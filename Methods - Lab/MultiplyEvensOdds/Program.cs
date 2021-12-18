using System;
using System.Runtime.InteropServices;

namespace MultiplyEvensOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {

            int evenSum = 0;
            while (number > 0)
            {
                int currentNum = number % 10;

                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }

                number /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int currentNum = number % 10;

                if (currentNum % 2 != 0)
                {
                    oddSum += currentNum;
                }

                number /= 10;
            }

            return oddSum;
        }

    }
}
