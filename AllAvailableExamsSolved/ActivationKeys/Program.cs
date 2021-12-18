using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string originalKey = key;

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Contains")
                {
                    string sub = commandArgs[1];

                    if (key.Contains(sub))
                    {
                        Console.WriteLine($"{key} contains {sub}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commandArgs[0] == "Flip")
                {
                    int start = int.Parse(commandArgs[2]);
                    int end = int.Parse(commandArgs[3]);

                    if (commandArgs[1] == "Upper")
                    {
                        int subtringToReplaceLength = end - start;
                        string substringToReplace = key.Substring(start, subtringToReplaceLength);
                        string newString = substringToReplace.ToUpper();
                        key = key.Replace(substringToReplace, newString);

                        Console.WriteLine(key);
                    }
                    else
                    {
                        string substringToReplace = key.Substring(start, end - start);
                        string newLines = substringToReplace.ToLower();
                        key = key.Replace(substringToReplace, newLines);

                        Console.WriteLine(key);
                    }

                }
                else if (commandArgs[0] == "Slice")
                {
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);

                    key = key.Remove(start, end - start);
                    Console.WriteLine(key);
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}