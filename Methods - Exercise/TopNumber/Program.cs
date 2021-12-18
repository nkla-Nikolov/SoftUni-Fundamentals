using System;
using System.Linq;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (DivisibleBy8(i) && HasOddNum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }


        static bool HasOddNum(int number)
        {
            int currentNum = number;
            
            while (number > 0)
            {
                currentNum = number % 10;
                
                if (currentNum % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        static bool DivisibleBy8(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
