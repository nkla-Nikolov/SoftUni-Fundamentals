using System;
using System.Collections.Generic;
using System.Linq;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> genres = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            string command = Console.ReadLine();


            while (command != "Stop!")
            {
                string[] commandArgs = command.Split();
                
                if (commandArgs[0] == "Join")
                {
                    string genre = commandArgs[1];

                    if (!genres.Contains(genre))
                    {
                        genres.Add(genre);
                    }
                }
                else if (commandArgs[0] == "Drop")
                {
                    string genre = commandArgs[1];
                    
                    if (genres.Contains(genre))
                    {
                        genres.Remove(genre);
                    }
                }
                else
                {
                    string oldGenre = commandArgs[1];
                    string newGenre = commandArgs[2];

                    if (genres.Contains(oldGenre) && genres.Contains(newGenre) == false)
                    {
                        int index = genres.IndexOf(oldGenre);
                        genres.Insert(index + 1, newGenre);
                        genres.Remove(oldGenre);
                    }
                }
                
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", genres));
        }
    }
}
