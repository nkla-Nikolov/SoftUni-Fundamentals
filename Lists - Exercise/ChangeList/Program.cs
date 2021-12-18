using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
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
                
                if (input[0] == "Delete")
                {
                    int element = int.Parse(input[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (input[0] == "Insert")
                {
                    int element = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    numbers.Insert(index, element);
                }
                
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
