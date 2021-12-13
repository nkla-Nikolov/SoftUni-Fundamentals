using System;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char word1 = char.Parse(Console.ReadLine());
            char word2 = char.Parse(Console.ReadLine());
            char word3 = char.Parse(Console.ReadLine());

            string text = char.ToString(word1) + char.ToString(word2) + char.ToString(word3);
            Console.WriteLine(text);
        }
    }
}
