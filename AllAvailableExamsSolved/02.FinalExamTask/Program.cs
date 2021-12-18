using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _02.FinalExamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int counter = 0;
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] splitted = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
                

                if (splitted[0] == "Like")
                {
                    string person = splitted[1];
                    string meal = splitted[2];

                    if (!guests.ContainsKey(person))
                    {
                        guests.Add(person, new List<string> {meal});
                    }
                    else
                    {
                        if (!guests[person].Contains(meal))
                        {
                            guests[person].Add(meal);
                        }
                    }

                }
                else if (splitted[0] == "Unlike")
                {
                    string person = splitted[1];
                    string meal = splitted[2];

                    if (!guests.ContainsKey(person))
                    {
                        Console.WriteLine($"{person} is not at the party.");
                    }
                    else
                    {
                        if (!guests[person].Contains(meal))
                        {
                            Console.WriteLine($"{person} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            Console.WriteLine($"{person} doesn't like the {meal}.");
                            guests[person].Remove(meal);
                            counter++;
                        }
                    }
                }
                
                command = Console.ReadLine();
            }

            

            foreach (var guest in guests.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }

            Console.WriteLine($"Unliked meals: {counter}");
        }
    }
}
