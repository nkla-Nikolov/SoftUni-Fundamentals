using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<int>> arr = new Dictionary<string, List<int>>();

            while (command != "Sail")
            {
                string[] commandArgs = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = commandArgs[0];
                int people = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);

                if (!arr.ContainsKey(town))
                {
                    arr.Add(town, new List<int> { people, gold });
                }
                else
                {
                    arr[town][0] += people;
                    arr[town][1] += gold;
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Plunder")
                {
                    string town = commandArgs[1];
                    int people = int.Parse(commandArgs[2]);
                    int gold = int.Parse(commandArgs[3]);

                    arr[town][0] -= people;
                    arr[town][1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (arr[town][0] <= 0 || arr[town][1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        arr.Remove(town);
                    }
                }
                else
                {
                    string town = commandArgs[1];
                    int gold = int.Parse(commandArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        arr[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {arr[town][1]} gold.");
                    }
                }


                command = Console.ReadLine();
            }

            if (arr.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {arr.Count} wealthy settlements to go to:");

            foreach (var kvp in arr.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value[0]} citizens, Gold: {kvp.Value[1]} kg");
            }
        }
    }
}
