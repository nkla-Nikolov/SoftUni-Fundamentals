using System;
using System.Linq;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("Move"))
                {
                    int numOfLetters = int.Parse(commandArgs[1]);
                    string firstLetters = message.Substring(0, numOfLetters);
                    message = message.Remove(0, numOfLetters);
                    message = message.Insert(message.Length, firstLetters);
                }
                else if (command.Contains("Insert"))
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];

                    message = message.Insert(index, value);
                }
                else if (command.Contains("ChangeAll"))
                {
                    string sub = commandArgs[1];
                    string replacement = commandArgs[2];

                    message = message.Replace(sub, replacement);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
