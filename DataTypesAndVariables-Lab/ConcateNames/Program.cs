using System;

namespace ConcateNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            string separator = Console.ReadLine();

            Console.WriteLine($"{name}{separator}{lastName}");
        }
    }
}
