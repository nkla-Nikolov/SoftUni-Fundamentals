using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Shoot")
                {
                    int index = int.Parse(commandArgs[1]);
                    int power = int.Parse(commandArgs[2]);

                    if (index >= targets.Count || index < 0)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commandArgs[0] == "Add")
                {
                    int index = int.Parse(commandArgs[1]);
                    int value = int.Parse(commandArgs[2]);

                    if (index >= targets.Count || index < 0)
                    {
                        Console.WriteLine("Invalid placement!");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        targets.Insert(index, value);
                    }
                }
                else if (commandArgs[0] == "Strike")
                {
                    int index = int.Parse(commandArgs[1]);
                    int radius = int.Parse(commandArgs[2]);

                    if (index - radius < 0 || index + radius >= targets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        targets.RemoveRange(index - radius, index + radius);
                    }
                    
                }
                
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
