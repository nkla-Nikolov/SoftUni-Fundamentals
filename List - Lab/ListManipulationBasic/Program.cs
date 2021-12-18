using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split();
                
                if (input[0] == "Add")
                {
                    int number = int.Parse(input[1]);
                    numbers.Add(number);
                }
                else if (input[0] == "Remove")
                {
                    int number = int.Parse(input[1]);
                    numbers.Remove(number);
                }
                else if (input[0] == "RemoveAt")
                {
                    int index = int.Parse(input[1]);
                    numbers.RemoveAt(index);
                }
                else if (input[0] == "Insert")
                {
                    int index = int.Parse(input[2]);
                    int number = int.Parse(input[1]);
                    numbers.Insert(index, number);
                }

                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
