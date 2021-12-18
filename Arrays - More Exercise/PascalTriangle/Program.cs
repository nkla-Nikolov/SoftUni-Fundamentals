using System;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            long[] firstArray = new long[input];
            long[] secondArray = new long[input];
            long[] printer = null;

            firstArray[0] = 1;
            secondArray[0] = 1;
            Console.WriteLine(1);

            for (int i = 1; i < input; i++)
            {
                for (int j = 1; j < input; j++)
                {
                    secondArray[j] = firstArray[j] + firstArray[j - 1];
                }

                firstArray = secondArray.ToArray();
                printer = new long[firstArray.Length - firstArray.Count(x => x == 0)];

                for (int j = 0; j < printer.Length; j++)
                {
                    printer[j] = firstArray[j];
                }

                Console.WriteLine(string.Join(" ", printer));
            }
        }
    }
}
