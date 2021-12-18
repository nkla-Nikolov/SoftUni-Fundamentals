using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "END")
            {
                Console.WriteLine(isPalindrome(text));
                text = Console.ReadLine();
            }
        }

        static bool isPalindrome(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}


