using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string car = splitted[0];
                int distance = int.Parse(splitted[1]);
                int fuel = int.Parse(splitted[2]);

                if (!cars.ContainsKey(car))
                {
                    cars.Add(car, new List<int> {distance, fuel});
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split(" : ");

                if (command.Contains("Drive"))
                {
                    string car = commandArgs[1];
                    int distance = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);

                    if (cars[car][1] >= fuel)
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    if (cars[car][0] > 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        cars.Remove(car);
                    }
                }
                else if (command.Contains("Refuel"))
                {
                    string car = commandArgs[1];
                    int fuel = int.Parse(commandArgs[2]);

                    if (cars[car][1] + fuel > 75)
                    {
                        Console.WriteLine($"{car} refueled with {75 - cars[car][1]} liters");
                        cars[car][1] = 75;
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                        cars[car][1] += fuel;
                    }
                }
                else if (command.Contains("Revert"))
                {
                    string car = commandArgs[1];
                    int kms = int.Parse(commandArgs[2]);

                    cars[car][0] -= kms;

                    if (cars[car][0] < 10000)
                    {
                        cars[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kms} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars.OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
