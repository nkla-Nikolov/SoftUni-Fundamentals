using System;

namespace LoweOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char text1 = char.Parse(Console.ReadLine());
            
            if (char.IsLower(text1))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
            
        }
    }
}
