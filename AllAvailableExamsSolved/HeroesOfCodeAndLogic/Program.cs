using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            int HP = 0;
            int MP = 0;

            for (int i = 0; i < numOfHeroes; i++)
            {
                string[] heroArgs = Console.ReadLine().Split();
                string heroName = heroArgs[0];
                HP = int.Parse(heroArgs[1]);
                MP = int.Parse(heroArgs[2]);

                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, new List<int> {HP, MP});
                }

            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgds = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                
                if (commandArgds[0] == "CastSpell")
                {
                    int neededMP = int.Parse(commandArgds[2]);
                    string spellName = commandArgds[3];
                    string heroName = commandArgds[1];

                    if (heroes[heroName][1] >= neededMP)
                    {
                        heroes[heroName][1] -= neededMP;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (commandArgds.Contains("TakeDamage"))
                {
                    string heroName = commandArgds[1];
                    int damage = int.Parse(commandArgds[2]);
                    string attacker = commandArgds[3];

                    int currentHP = heroes[heroName][0] - damage;
                    heroes[heroName][0] -= damage;

                    if (currentHP > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currentHP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                else if (commandArgds.Contains("Recharge"))
                {
                    string heroName = commandArgds[1];
                    int amount = int.Parse(commandArgds[2]);

                    if (heroes[heroName][1] + amount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - heroes[heroName][1]} MP!");
                        heroes[heroName][1] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        heroes[heroName][1] += amount;
                    }
                }
                else if (commandArgds.Contains("Heal"))
                {
                    string heroName = commandArgds[1];
                    int amount = int.Parse(commandArgds[2]);

                    if (heroes[heroName][0] + amount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroes[heroName][0]} HP!");
                        heroes[heroName][0] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        heroes[heroName][0] += amount;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
