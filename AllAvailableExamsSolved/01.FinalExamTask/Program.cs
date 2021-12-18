using System;
using System.Linq;
using System.Text;

namespace _01.FinalExamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Registration")
            {
                string[] commandArgs = command.Split();

                if (command.Contains("Letters"))
                {
                    if (commandArgs[1] == "Upper")
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                    else
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                }
                else if (command.Contains("Reverse"))
                {
                    
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);


                    if (start < 0 || end > username.Length - 1)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    string sub = username.Substring(start, end - start + 1);
                    //string reversed = null;

                    StringBuilder reversed = new StringBuilder();
                    for (int i = sub.Length - 1; i >= 0; i--)
                    {
                        reversed.Append(sub[i]);
                    }

                    Console.WriteLine(reversed);
                }
                else if (command.Contains("Substring"))
                {
                    string sub = commandArgs[1];

                    if (username.Contains(sub))
                    {
                        int indexSub = username.IndexOf(sub);
                        username = username.Remove(indexSub, sub.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The username {username} doesn't contain {sub}.");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (command.Contains("Replace"))
                {
                    char symbol = char.Parse(commandArgs[1]);

                    username = username.Replace(symbol, '-');
                    Console.WriteLine(username);
                }
                else if (command.Contains("IsValid"))
                {
                    char symbol = char.Parse(commandArgs[1]);

                    if (username.Contains(symbol))
                    {
                        Console.WriteLine($"Valid username.");
                    }
                    else
                    {
                        Console.WriteLine($"{symbol} must be contained in your username.");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
