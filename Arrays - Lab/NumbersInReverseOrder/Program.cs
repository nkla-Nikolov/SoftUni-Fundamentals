using System;
using System.Linq;

namespace NumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
           int nums = int.Parse(Console.ReadLine());
           
           int[] array = new int[nums];
          
           for (int i = 0; i < array.Length; i++)
           {
               array[i] = int.Parse(Console.ReadLine());
           }
          
           for (int i = array.Length - 1; i >= 0; i--)
           {
               Console.Write(array[i] + " ");
           }
          
        }
    }
}
