using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FinalExamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> usernames = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();

            while (command != "Log out")
            {
                string[] commandArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("New follower"))
                {
                    string follower = commandArgs[1];

                    if (usernames.ContainsKey(follower))
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    usernames.Add(follower, new List<int> {0, 0});
                }
                else if (command.Contains("Like"))
                {
                    string follower = commandArgs[1];
                    int count = int.Parse(commandArgs[2]);

                    if (!usernames.ContainsKey(follower))
                    {
                        usernames.Add(follower, new List<int> {count, 0});
                    }
                    else
                    {
                        usernames[follower][0] += count;
                    }
                }
                else if (command.Contains("Comment"))
                {
                    string follower = commandArgs[1];

                    if (!usernames.ContainsKey(follower))
                    {
                        usernames.Add(follower, new List<int> {0, 1});
                    }
                    else
                    {
                        usernames[follower][1] += 1;
                    }
                }
                else
                {
                    string follower = commandArgs[1];

                    if (usernames.ContainsKey(follower))
                    {
                        usernames.Remove(follower);
                    }
                    else
                    {
                        Console.WriteLine($"{follower} doesn't exist.");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var user in usernames)
            {
                int sum = user.Value.Sum();
                user.Value[0] = sum;

                if (user.Value.Count > 1)
                {
                    user.Value.RemoveRange(1, user.Value.Count - 1);
                }
            }

            Console.WriteLine($"{usernames.Count} followers");
            foreach (var user in usernames.OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value[0]}");
            }
        }
    }
}
