﻿using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VowelsCount(text));
        }

        static int VowelsCount (string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'A')
                {
                    counter++;
                }
                else if (text[i] == 'e' || text[i] == 'E')
                {
                    counter++;
                }
                else if (text[i] == 'i' || text[i] == 'I')
                {
                    counter++;
                }
                else if (text[i] == 'o' || text[i] == 'O')
                {
                    counter++;
                }
                else if (text[i] == 'u' || text[i] == 'U')
                {
                    counter++;
                }

            }

            return counter;
        }
    }
}
