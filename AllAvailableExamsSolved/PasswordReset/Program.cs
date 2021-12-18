using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                if (command == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        sb.Append(password[i]);
                    }

                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (command.Contains("Cut"))
                {
                    string[] commandArgs = command.Split();
                    int index = int.Parse(commandArgs[1]);
                    int lenght = int.Parse(commandArgs[2]);

                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if (command.Contains("Substitute"))
                {
                    string[] commandArgs = command.Split();
                    string oldReplacer = commandArgs[1];
                    string newReplacer = commandArgs[2];

                    if (password.Contains(oldReplacer))
                    {
                        password = password.Replace(oldReplacer, newReplacer);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
