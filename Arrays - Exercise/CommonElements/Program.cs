using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in secondArray)
            {
                foreach (var element in firstArray)
                {
                    if (item == element)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
        }
    }
}
