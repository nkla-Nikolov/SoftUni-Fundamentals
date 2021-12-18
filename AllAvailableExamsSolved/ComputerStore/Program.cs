using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double totalPrice = 0;
            double taxes = 0;

            while (command != "special" && command != "regular")
            {
                double price = double.Parse(command);
                
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                totalPrice += price;

                command = Console.ReadLine();

            }

            taxes = totalPrice * 0.20;

            if (totalPrice + taxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (command == "special")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPrice + taxes) * 0.90:f2}$");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice + taxes:f2}$");
        }
    }
}
