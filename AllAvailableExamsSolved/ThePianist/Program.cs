using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> songs = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string piece = splitted[0];
                string composer = splitted[1];
                string key = splitted[2];

                songs.Add(piece, new List<string> { composer, key });

            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("Add"))
                {
                    string piece = commandArgs[1];
                    string composer = commandArgs[2];
                    string key = commandArgs[3];

                    if (songs.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        songs.Add(piece, new List<string> {composer, key});
                    }
                }
                else if (command.Contains("Remove"))
                {
                    string piece = commandArgs[1];

                    if (songs.ContainsKey(piece))
                    {
                        songs.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (command.Contains("ChangeKey"))
                {
                    string piece = commandArgs[1];
                    string newKey = commandArgs[2];

                    if (songs.ContainsKey(piece))
                    {
                        songs[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var piece in songs.OrderBy(x => x.Key)
                .ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
