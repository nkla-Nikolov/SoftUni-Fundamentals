using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersPerWagon = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var waggonCapacity = Convert.ToInt32(Console.ReadLine());
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (waggonCapacity <= 0)
            {
                return;
            }

            while (input[0] != "end")
            {
                if (input.Length == 2)
                {
                    AddWaggon(passengersPerWagon, waggonCapacity, input);
                }

                if (input.Length == 1)
                {
                    AddPassengers(passengersPerWagon, waggonCapacity, input);
                }

                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(' ', passengersPerWagon));
        }

        private static void AddWaggon(List<int> passengersPerWagon, int capacity, string[] input)
        {
            if (int.Parse(input[1]) > capacity)
            {
                return;
            }

            passengersPerWagon.Add(int.Parse(input[1]));
        }

        private static void AddPassengers(List<int> passengersPerWagon, int waggonCapacity, string[] input)
        {

            int passengers = Convert.ToInt32(input[0]);
            for (int i = 0; i < passengersPerWagon.Count - 1; i++)
            {
                if (passengersPerWagon[i] + passengers <= waggonCapacity)
                {
                    passengersPerWagon[i] += passengers;
                    return;
                }
            }
        }
    }
}

