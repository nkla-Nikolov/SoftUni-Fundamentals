using System;
using System.Threading;
using System.Collections;


namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            double originalValueOfN = n * 0.5;
            int targets = 0;
            
            while (n >= m)
            {
                n -= m;
                if (n == originalValueOfN)
                {
                    n /= y;
                    
                }
                
                targets++;
            }

            Console.WriteLine(n);
            Console.WriteLine(targets);
        }
    }
}
