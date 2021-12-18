using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> allResources = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool itemDone = false;
            string legendaryItem = "";
            while (itemDone == false)
            {
                string[] resources = Console.ReadLine().Split();

                for (int i = 0; i < resources.Length; i += 2)
                {
                    int quantity = int.Parse(resources[i]);
                    string item = resources[i + 1].ToLower();

                    if (item == "fragments" || item == "shards" || item == "motes")
                    {
                        if (!allResources.ContainsKey(item))
                        {
                            allResources.Add(item, 0);
                        }

                        allResources[item] += quantity;
                    }
                    else
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, 0);
                        }

                        junk[item] += quantity;
                    }

                    if (allResources.Any(x => x.Value >= 250))
                    {
                        if (allResources["fragments"] >= 250)
                        {
                            legendaryItem = "Valanyr";
                            allResources["fragments"] -= 250;
                            Console.WriteLine($"{legendaryItem} obtained!");
                        }
                        else if (allResources["shards"] >= 250)
                        {
                            legendaryItem = "Shadowmourne";
                            allResources["shards"] -= 250;
                            Console.WriteLine($"{legendaryItem} obtained!");
                        }
                        else if (allResources["motes"] >= 250)
                        {
                            legendaryItem = "Dragonwrath";
                            allResources["motes"] -= 250;
                            Console.WriteLine($"{legendaryItem} obtained!");
                        }

                        itemDone = true;
                        break;
                    }
                }
            }
            

            foreach (var item in allResources.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
