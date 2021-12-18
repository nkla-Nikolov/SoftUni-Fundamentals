using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedStrings = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var currentWord in bannedStrings)
            {
                if (text.Contains(currentWord))
                {
                    text = text.Replace(currentWord, new string('*', currentWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}

