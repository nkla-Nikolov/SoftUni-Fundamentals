using System;
using System.Collections.Generic;

namespace _02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, int> final = new Dictionary<string, int>();

            while (command != "stop")
            {

                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (!final.ContainsKey(resource))
                {
                    final.Add(resource, quantity);
                }
                else
                {
                    final[resource] += quantity;
                }

                
                command = Console.ReadLine();
            }

            foreach (var item in final)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
