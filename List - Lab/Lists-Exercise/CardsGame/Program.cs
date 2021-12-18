using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < firstPlayer.Count; i++)
            {
                for (int j = 0; j < secondPlayer.Count; j++)
                {
                    if (firstPlayer[i] == secondPlayer[j])
                    {
                        
                    }
                }
            }
        }
    }
}
