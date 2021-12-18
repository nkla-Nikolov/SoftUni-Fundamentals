using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            List<int> lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            for (int i = 0; i < lift.Count; i++)
            {
                while (lift[i] < 4 && peopleWaiting > 0)
                {
                    lift[i]++;
                    peopleWaiting--;
                }

            }
            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
