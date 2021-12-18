using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputUsernames = Console.ReadLine().Split(", ");
            bool isValid = false;

            for (int i = 0; i < inputUsernames.Length; i++)
            {
                if (inputUsernames[i].Length >= 3 && inputUsernames[i].Length <= 16)
                {
                    foreach (var symbol in inputUsernames[i])
                    {
                        if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                        {
                            isValid = false;
                            break;
                        }
                        isValid = true;
                    }
                    if (isValid)
                    {
                        Console.WriteLine(inputUsernames[i]);
                    }
                }
            }
        }
    }
}
