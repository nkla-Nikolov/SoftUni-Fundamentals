using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Add")
                {
                    string phone = commandArgs[1];

                    if (phones.Contains(phone))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        phones.Add(phone);
                    }
                }
                else if (commandArgs[0] == "Remove")
                {
                    string phone = commandArgs[1];

                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                    }
                    
                }
                else if (commandArgs[0] == "Bonus phone")
                {
                    string[] splitted = commandArgs[1].Split(":");

                    string oldPhone = splitted[0];
                    string newPhone = splitted[1];
                    int index = phones.IndexOf(oldPhone);
                    
                    if (phones.Contains(oldPhone))
                    {
                        phones.Insert(index + 1, newPhone);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandArgs[0] == "Last")
                {
                    string phone = commandArgs[1];
                    
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                        phones.Add(phone);
                    }
                    
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
