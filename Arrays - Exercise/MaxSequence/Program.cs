using System;
using System.Linq;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            int winningCounter = 0;
            int num = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > winningCounter)
                {
                    winningCounter = counter;
                    num = array[i];
                }
            }

            for (int i = 0; i < winningCounter; i++)
            {
                Console.Write(num + " ");
            }

        }
    }
}
