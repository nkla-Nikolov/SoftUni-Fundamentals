using System;
using System.Linq;

namespace _05.DigitsLettersOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = "";
            string letters = "";
            string others = "";
            
            for (int i = 0; i < text.Length; i++)
            {
                bool isDigit = char.IsDigit(text[i]);
                bool isLetter = char.IsLetter(text[i]);

                if (isDigit)
                {
                    digits += text[i];
                }
                else if (isLetter)
                {
                    letters += text[i];
                }
                else
                {
                    others += text[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }

    }
}
