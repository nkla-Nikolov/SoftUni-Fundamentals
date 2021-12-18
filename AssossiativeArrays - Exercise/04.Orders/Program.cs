using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            
            

            while (command != "buy")
            {
                string[] input = command.Split();
                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new double[2]);
                }

                int startingQuantity = (int)products[product][1];
                double[] totalQuantity = new double[] {price, startingQuantity + quantity};
                products[product] = totalQuantity;
                
                command = Console.ReadLine();
            }

            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];

                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
