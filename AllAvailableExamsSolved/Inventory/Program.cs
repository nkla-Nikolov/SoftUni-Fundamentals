using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] commandArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Collect")
                {
                    string item = commandArgs[1];

                    if (journal.Contains(item))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        journal.Add(item);
                    }
                }
                else if (commandArgs[0] == "Drop")
                {
                    string item = commandArgs[1];

                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                else if (commandArgs[0] == "Combine Items")
                {
                    // Combine items - Sword:Bow
                    string[] combineItems = commandArgs[1].Split(":");
                    string oldItem = combineItems[0];
                    string newItem = combineItems[1];
                    
                    bool oldExist = journal.Contains(oldItem);


                    if (oldExist)
                    {
                        int olditemIndex = journal.IndexOf(oldItem);
                        journal.Insert(olditemIndex + 1, newItem);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandArgs[0] == "Renew")
                {
                    string item = commandArgs[1];

                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
