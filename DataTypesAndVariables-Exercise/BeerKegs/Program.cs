using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte totalKegs = byte.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string modelName = "";
            
            for (int i = 1; i <= totalKegs; i++)
            {
                string modelKeg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double kegsVolume = Math.PI * (Math.Pow(radius, 2)) * height;

                double currentKeg = kegsVolume;

                if (currentKeg > biggestKeg)
                {
                    biggestKeg = currentKeg;
                    modelName = modelKeg;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine(modelName);

        }
    }
}
