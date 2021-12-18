using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = splitted[0];
                int rarity = int.Parse(splitted[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new List<double> { rarity });
                }
                else
                {
                    plants[plant][0] = rarity;
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commandArgs = command.Split(new char[] { '-', ':',' ' }, StringSplitOptions.RemoveEmptyEntries);
                string plant = commandArgs[1];

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    command = Console.ReadLine();
                    continue;
                }
                if (command.Contains("Rate"))
                {
                    double rating = double.Parse(commandArgs[2]);
                    plants[plant].Add(rating);
                }
                else if (command.Contains("Update"))
                {
                    double rarity = double.Parse(commandArgs[2]);
                    plants[plant][0] = rarity;
                }
                else if (command.Contains("Reset"))
                {
                    plants[plant].RemoveRange(1, plants[plant].Count - 1);
                }
                else
                {
                    Console.WriteLine("error");
                }


                command = Console.ReadLine();
            }

            foreach (var item in plants)
            {
                double rarity = item.Value[0];

                item.Value.RemoveAt(0);

                int count = item.Value.Count;

                double sum = item.Value.Sum();

                if (sum != 0)
                {
                    sum /= count;
                }
                item.Value.Clear();
                item.Value.Add(rarity);
                item.Value.Add(sum);
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(x => x.Value[0])
                .ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }
    }
}
