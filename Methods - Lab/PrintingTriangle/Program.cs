using System;
using System.Runtime.Serialization;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Triangle(i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Triangle(i);
            }
        }

        static void Triangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
