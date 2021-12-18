using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> plates = new Dictionary<string, string>();

            string username = "";
            string licensePlate = "";

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                username = input[1];

                if (command == "register")
                {
                    licensePlate = input[2];
                    if (!plates.ContainsKey(username))
                    {
                        plates.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else
                {
                    if (plates.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        plates.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var VARIABLE in plates)
            {
                Console.WriteLine($"{VARIABLE.Key} => {VARIABLE.Value}");
            }
        }
    }
}
