using System;
using System.Linq;
using System.Text.Json;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {


            
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                flag = false;
                
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }
                for (int j = 1 + i; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                if (sumLeft != sumRight)
                {
                    flag = true;
                }
                else if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
