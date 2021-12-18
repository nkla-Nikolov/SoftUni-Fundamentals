using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<char, int> final = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (var ch in word)
                {
                    if (!final.ContainsKey(ch))
                    {
                        final.Add(ch, 1);
                    }
                    else
                    {
                        final[ch]++;
                    }
                }
            }

            foreach (var items in final)
            {
                Console.WriteLine($"{items.Key} -> {items.Value}");
            }


            //string text = Console.ReadLine();

            //Dictionary<char, int> final = new Dictionary<char, int>();

            //foreach (var ch in text)
            //{
            //    if (!final.ContainsKey(ch))
            //    {
            //        final.Add(ch, 1);
            //    }
            //    else if (final.ContainsKey(ch))
            //    {
            //        final[ch]++;
            //    }

            //}

            //foreach (KeyValuePair<char, int> ch in final.Where(a => a.Key != ' '))
            //{
            //    Console.WriteLine($"{ch.Key} -> {ch.Value}");
            //}

        }
    }
}
