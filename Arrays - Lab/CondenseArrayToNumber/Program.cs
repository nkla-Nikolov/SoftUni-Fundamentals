using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array = Console.ReadLine()
            //     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //     .Select(int.Parse)
            //     .ToArray();
            //
            // int[] condesedArray = new int[array.Length];
            //
            // if (array.Length == 1)
            // {
            //     Console.WriteLine(array[0]);
            //     return;
            // }
            //
            // for (int i = 0; i < array.Length - 1; i++)
            // {
            //     for (int j = 0; j < condesedArray.Length - 1; j++)
            //     {
            //         condesedArray[j] = array[j] + array[j + 1];
            //     }
            //     array = condesedArray;
            // }
            //
            // 
            // Console.WriteLine(condesedArray[0]);


            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }

                nums = condensed;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
