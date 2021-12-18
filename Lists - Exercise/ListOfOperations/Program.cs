using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Add")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Add(number);
                }
                else if (commandArgs[0] == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (commandArgs[0] == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (commandArgs[1] == "left")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstNum = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstNum);
                    }
                    
                }
                else if (commandArgs[1] == "right")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastNum = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastNum);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
