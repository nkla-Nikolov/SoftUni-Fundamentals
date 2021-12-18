using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            bool isChanged = false;
            while (command != "end")
            {
                string[] input = command.Split();

                if (input[0] == "Contains")
                {
                    int number = int.Parse(input[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (input[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (input[0] == "Filter")
                {
                    string condition = input[1];
                    int number = int.Parse(input[2]);
                    if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > number)));
                    }
                    if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= number)));
                    }
                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < number)));
                    }
                    if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= number)));
                    }
                }
                else if (input[0] == "Add")
                {
                    int numbedAdd = int.Parse(input[1]);
                    numbers.Add(numbedAdd);
                    isChanged = true;
                }
                else if (input[0] == "Remove")
                {
                    int removedNumber = int.Parse(input[1]);
                    numbers.Remove(removedNumber);
                    isChanged = true;
                }
                else if (input[0] == "RemoveAt")
                {
                    int index = int.Parse(input[1]);
                    numbers.RemoveAt(index);
                    isChanged = true;
                }
                else if (input[0] == "Insert")
                {
                    int number = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    numbers.Insert(index, number);
                    isChanged = true;
                }


                command = Console.ReadLine();


            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}
