using System;
using System.Linq;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("InsertSpace"))
                {
                    int index = int.Parse(commandArgs[1]);

                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command.Contains("Reverse"))
                {
                    string sub = commandArgs[1];

                    if (message.Contains(sub))
                    {
                        int indexOfSub = message.IndexOf(sub);
                        message = message.Remove(indexOfSub, sub.Length);
                        string reversedSub = "";
                        for (int i = sub.Length - 1; i >= 0; i--)
                        {
                            reversedSub += sub[i];
                        }
                        message = message.Insert(message.Length, reversedSub);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command.Contains("ChangeAll"))
                {
                    string sub = commandArgs[1];
                    string replacer = commandArgs[2];

                    message = message.Replace(sub, replacer);
                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
