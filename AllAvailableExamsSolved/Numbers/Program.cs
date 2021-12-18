using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double sum = nums.Sum();

            double averageNum = sum / nums.Count;

            List<int> greaterNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > averageNum)
                {
                    greaterNums.Add(nums[i]);
                }
            }

            if (greaterNums.Count <= 0)
            {
                Console.WriteLine("No");
                return;
            }

            greaterNums.Sort();
            greaterNums.Reverse();
            
            for (int i = 0; i < greaterNums.Count; i++)
            {
                Console.Write(greaterNums[i] + " ");

                if (i > 3)
                {
                    break;
                }
            }
        }
    }
}
