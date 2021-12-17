using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstNum;
                    secondArray[i] = secondNum;
                }
                else
                {
                    firstArray[i] = secondNum;
                    secondArray[i] = firstNum;
                }

            }

            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }

            

            //Console.WriteLine(string.Join(" ", firstArray));
            //Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
