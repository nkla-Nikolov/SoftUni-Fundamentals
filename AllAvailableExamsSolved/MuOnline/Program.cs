using System;
using System.ComponentModel.Design;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] room = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < room.Length; i++)
            {
                string[] command = room[i].Split();
                
                if (command[0] == "potion")
                {
                    int regenerate = int.Parse(command[1]);
                    int diff = 100 - health;
                    
                    if (regenerate + health > 100)
                    {
                        Console.WriteLine($"You healed for {diff} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        health += regenerate;
                        Console.WriteLine($"You healed for {regenerate} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    

                }
                else if (command[0] == "chest")
                {
                    int amaountBitcoins = int.Parse(command[1]);
                    bitcoins += amaountBitcoins;
                    Console.WriteLine($"You found {amaountBitcoins} bitcoins.");
                }
                else
                {
                    string monster = command[0];
                    int demage = int.Parse(command[1]);

                    health -= demage;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }

            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }

    }

}


