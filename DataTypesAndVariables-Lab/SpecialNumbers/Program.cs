using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumDigit = 0;
                int number = i;
               
                while (number > 0)
                {
                    sumDigit += number % 10;
                    number /= 10;
                }

                bool flag = false;
                
                if (sumDigit == 7 || sumDigit == 5 || sumDigit == 11)
                {
                    flag = true;
                }

                Console.WriteLine($"{i} -> {flag}");
            }
        }
    }
}
