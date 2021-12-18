using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parts = Console.ReadLine()
                .Split("|")
                .ToList();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Add")
                {
                    string item = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < parts.Count)
                    {
                        parts.Insert(index, item);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandArgs[0] == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index >= 0 && index < parts.Count)
                    {
                        parts.RemoveAt(index);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandArgs[1] == "Even")
                {
                    for (int i = 0; i < parts.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"{parts[i]} ");
                        }
                    }

                    Console.WriteLine();
                }
                else if (commandArgs[1] == "Odd")
                {
                    for (int i = 0; i < parts.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write($"{parts[i]} ");
                        }
                    }

                    Console.WriteLine();
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", parts)}!");
        }
    }
}
