using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());

            Console.WriteLine(GetArea(width, heigh));
        }

        static double GetArea (double width, double heigh)
        {
            double area = heigh * width;
            return area;
        }
    }
}
