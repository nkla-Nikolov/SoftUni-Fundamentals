using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
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

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "swap")
                {
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);
                    int firstNumber = numbers[index1];
                    int secondNumber = numbers[index2];

                    numbers[index1] = secondNumber;
                    numbers[index2] = firstNumber;
                }
                else if (commandArgs[0] == "multiply")
                {
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);
                    int firstNumber = numbers[index1];
                    int secondNumber = numbers[index2];

                    int newNumber = firstNumber * secondNumber;
                    numbers[index1] = newNumber;
                    //numbers.Insert(index1, newNumber);
                    //numbers.RemoveAt(index1 + 1);
                    
                }
                else if (commandArgs[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
