using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandArgs = command.Split(":");

                if (command.Contains("Add Stop"))
                {
                    int index = int.Parse(commandArgs[1]);
                    string text = commandArgs[2];

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, text);
                    }

                    Console.WriteLine(stops);
                }
                else if (command.Contains("Remove Stop"))
                {
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);

                    if (start >= 0 && end < stops.Length)
                    {
                        stops = stops.Remove(start, end - start + 1);
                    }

                    Console.WriteLine(stops);
                }
                else
                {
                    string oldText = commandArgs[1];
                    string newText = commandArgs[2];

                    if (stops.Contains(oldText))
                    {
                        stops = stops.Replace(oldText, newText);
                    }

                    Console.WriteLine(stops);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
