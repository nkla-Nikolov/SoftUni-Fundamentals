using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Text(input, n);
        }

        static string Text(string text, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(text);
            }

            return text;
        }
    }
}
