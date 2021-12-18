using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-z]+)<<(?<price>[\d]+\.{0,1}[\d]{0,})!(?<quantity>[\d]+)";
            decimal totalPrice = 0;
            string input = Console.ReadLine();
            Console.WriteLine($"Bought furniture:");


            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string item = match.Groups["furniture"].Value;
                decimal itemPrice = decimal.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);
                totalPrice += itemPrice * quantity;

                Console.WriteLine(item);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
