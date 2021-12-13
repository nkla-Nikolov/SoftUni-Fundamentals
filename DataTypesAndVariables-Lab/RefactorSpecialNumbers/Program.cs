using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = GetLastDigit(i);
                bool isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isTrue);

            }
        }

        static int GetLastDigit(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }

            return sum;
        }
    }
}
