using System;

namespace WaterFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPours = int.Parse(Console.ReadLine());
            int capacity = 255;
            int totalPoured = 0;
            for (int i = 0; i < numOfPours; i++)
            {
                int waterPour = int.Parse(Console.ReadLine());
                totalPoured += waterPour;
                if (totalPoured > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalPoured -= waterPour;
                }
                
            }

            Console.WriteLine(totalPoured);
            
        }
    }
}
