using System;

namespace MiddleCharecters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Middlechar(text));
        }

        static string Middlechar (string text)
        {
            string result = "";

            if (text.Length % 2 != 0)
            {
                result = text[text.Length / 2].ToString();
            }
            else
            {
                result = text[text.Length / 2 - 1] + text[(text.Length / 2)].ToString();
            }

            return result;
        }
    }
}
