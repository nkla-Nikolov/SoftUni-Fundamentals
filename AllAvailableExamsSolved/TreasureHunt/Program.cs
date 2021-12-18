using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Loot")
                {
                    for (int i = 1; i < commandArgs.Length; i++)
                    {
                        if (!chest.Contains(commandArgs[i]))
                        {
                            string item = commandArgs[i];
                            chest.Insert(0, item);
                        }
                    }
                }
                else if (commandArgs[0] == "Drop")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index < 0 || index >= chest.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    string item = chest[index];
                    chest.RemoveAt(index);
                    chest.Add(item);
                }
                else if (commandArgs[0] == "Steal")
                {
                    int count = int.Parse(commandArgs[1]);

                    if (count > chest.Count)
                    {
                        Console.WriteLine(string.Join(", ", chest));
                        chest.Clear();
                    }
                    else
                    {
                        List<string> removed = new List<string>();

                        for (int i = chest.Count - count; i < chest.Count; i++)
                        {
                            removed.Add(chest[i]);
                        }

                        Console.WriteLine(string.Join(", ", removed));
                        removed.Clear();
                        chest.RemoveRange(chest.Count - count, count);
                    }

                }

                command = Console.ReadLine();
            }

            int sum = 0;

            for (int i = 0; i < chest.Count; i++)
            {
                string word = chest[i];

                for (int j = 0; j < word.Length; j++)
                {
                    sum += 1;
                }
            }

            double avg = sum * 1.0 / chest.Count;

            if (chest.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");
            }

        }
    }
}
