using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[] arr = new BigInteger[n];
            arr = array(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static BigInteger[] array(BigInteger[] array)
        {
            if (array.Length <= 3)
            {
                if (array.Length == 1)
                {
                    array[0] = 1;
                }
                else if (array.Length == 2)
                {
                    array[0] = 1;
                    array[1] = 1;
                }
                else if (array.Length == 3)
                {
                    array[0] = 1;
                    array[1] = 1;
                    array[2] = 2;
                }
            }
            else
            {
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;

                for (int i = 3; i < array.Length; i++)
                {
                    array[i] = array[i - 3] + array[i - 2] + array[i - 1];
                }
            }
            
            return array;
        }
    }
}
