using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Urgent")
                {
                    string item = commandArgs[1];

                    if (products.Contains(item))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        products.Insert(0, item);
                    }
                }
                else if (commandArgs[0] == "Unnecessary")
                {
                    string item = commandArgs[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandArgs[0] == "Correct")
                {
                    string oldItem = commandArgs[1];
                    string newItem = commandArgs[2];

                    if (products.Contains(oldItem))
                    {
                        int indexOfOldElement = products.IndexOf(oldItem);
                        products.Remove(oldItem);
                        products.Insert(indexOfOldElement, newItem);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandArgs[0] == "Rearrange")
                {
                    string item = commandArgs[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", products));
        }
    }
}
