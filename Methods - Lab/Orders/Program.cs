using System;
using System.Numerics;
using System.Reflection;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfSnack = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (typeOfSnack == "coffee")
            {
                Coffee(quantity);
            }
            else if (typeOfSnack == "water")
            {
                Water(quantity);
            }
            else if (typeOfSnack == "coke")
            {
                Coke(quantity);
            }
            else if (typeOfSnack == "snacks")
            {
                Snacks(quantity);
            }
        }

        static void Coffee(double price)
        {
            Console.WriteLine($"{price * 1.5:f2}");
        }

        static void Water(double price)
        {
            Console.WriteLine($"{price * 1:f2}");
        }

        static void Coke(double price)
        {
            Console.WriteLine($"{price * 1.4:f2}");
        }

        static void Snacks(double price)
        {
            Console.WriteLine($"{price * 2:f2}");
        }
    }
}
