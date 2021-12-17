﻿using System;
using System.Linq;

namespace ArrayRotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int rotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                string firstElement = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    int prevIndex = i - 1;
                    array[prevIndex] = array[i];
                }

                array[array.Length - 1] = firstElement;
            }
            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
