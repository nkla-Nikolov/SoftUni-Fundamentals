using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            float population = float.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());


            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
