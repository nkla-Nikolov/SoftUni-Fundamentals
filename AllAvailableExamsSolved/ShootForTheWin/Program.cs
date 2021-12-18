using System;
using System.Linq;
using System.Collections.Generic;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int counter = 0;

            while (command != "End")
            {
                int currentIndex = int.Parse(command);

                if (currentIndex >= nums.Count || currentIndex < 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == -1 || i == currentIndex)
                    {
                        continue;
                    }
                    
                    if (nums[i] > nums[currentIndex])
                    {
                        nums[i] -= nums[currentIndex];
                    }
                    else if (nums[i] <= nums[currentIndex])
                    {
                        nums[i] += nums[currentIndex];
                    }
                    
                }

                nums[currentIndex] = -1;
                counter++;

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", nums)}");

        }
    }
}
