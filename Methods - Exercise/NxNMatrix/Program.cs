using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Matrix(n));
        }

        static int Matrix(int num)
        {
            for (int rows = 0; rows < num; rows++)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }

            return num;
        }

    }
}
