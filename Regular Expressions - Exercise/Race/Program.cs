using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string lettersPattern = @"[A-Za-z]";
            string digitsPattern = @"[\d]";
            Dictionary<string, int> contestants = new Dictionary<string, int>();

            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in names)
            {
                if (!contestants.ContainsKey(person))
                {
                    contestants.Add(person, 0);
                }
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchName = Regex.Matches(input, lettersPattern);
                MatchCollection matchKMs = Regex.Matches(input, digitsPattern);
                string name = null;
                foreach (Match letter in matchName)
                {
                    name += letter;
                }

                if (!contestants.ContainsKey(name))
                {
                    input = Console.ReadLine();
                    continue;
                }

                int distanceValue = 0;
                foreach (Match digit in matchKMs)
                {
                    distanceValue += int.Parse(digit.Value);
                }

                contestants[name] += distanceValue;
                input = Console.ReadLine();
            }
            byte counter = 1;

            foreach (var racer in contestants.OrderByDescending(x => x.Value))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                }

                counter++;
            }
        }
    }
}
