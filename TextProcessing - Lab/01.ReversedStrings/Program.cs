using System;
using System.Linq;
using System.Text;

namespace _01.ReversedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string text = command;

                char[] arrReversed = text.Reverse().ToArray();
                Console.WriteLine($"{text} = {string.Join("", arrReversed)}");
                
                command = Console.ReadLine();
            }
        }
    }
}
