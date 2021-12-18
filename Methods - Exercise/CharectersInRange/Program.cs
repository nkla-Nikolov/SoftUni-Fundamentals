using System;
using System.Threading;

namespace CharectersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            
            PrintChars(start, end);
        }

        static void PrintChars(char text1, char text2)
        {
            int start = Math.Min(text1, text2);
            int end = Math.Min(text1, text2);

            for (int i = start; i <= end; i++)
            {
                Console.Write((char) i + " ");
            }

            Console.WriteLine();
        }

    }
}
