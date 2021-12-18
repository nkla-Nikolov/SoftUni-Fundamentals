using System;
using System.Runtime.CompilerServices;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Integer(number));
            }
            else if (type == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Number(number):f2}");
            }
            else if (type == "string")
            {
                string text = Console.ReadLine();
                Text(text);
            }
        }

        static int Integer(int result)
        {
            result *= 2;
            return result;
        }

        static double Number(double result)
        {
            result *= 1.5;
            return result;
        }

        static void Text(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
