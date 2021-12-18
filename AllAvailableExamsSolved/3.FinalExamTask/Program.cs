using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.FinalExamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern =
                    @"^(.+)>(?<nums>[\d]{3})\|(?<lowers>[a-z]{3})\|(?<uppers>[A-Z]{3})\|(?<symbolsExcept>[^<>]{3})<\1$";

                bool isMatch = Regex.IsMatch(input, pattern);
                Match match = Regex.Match(input, pattern);

                //string password = null;

                if (isMatch)
                {
                    // password += match.Groups["nums"].Value;
                    // password += match.Groups["lowers"].Value;
                    // password += match.Groups["uppers"].Value;
                    // password += match.Groups["symbolsExcept"].Value;
                    // Console.WriteLine($"Password: {password}");

                    sb.Append(match.Groups["nums"].Value);
                    sb.Append(match.Groups["lowers"].Value);
                    sb.Append(match.Groups["uppers"].Value);
                    sb.Append(match.Groups["symbolsExcept"].Value);
                    Console.WriteLine($"Password: {sb}");
                }
                else
                {
                    Console.WriteLine($"Try another password!");
                }

                sb.Clear();
            }
        }
    }
}
