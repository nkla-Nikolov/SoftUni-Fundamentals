using System;
using System.Linq;

namespace _18.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            long[] ladyBugsPosition = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int i = 0; i < ladyBugsPosition.Length; i++)
            {
                if (ladyBugsPosition[i] > fieldSize - 1 || ladyBugsPosition[i] < 0)
                {
                    continue;
                }
                else
                {
                    field[ladyBugsPosition[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] movement = command.Split();
                int ladyBugIndex = int.Parse(movement[0]);
                string direction = movement[1];
                int flyLength = int.Parse(movement[2])

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                int destinationIndex = ladyBugIndex + flyLength;

                if (ladyBugIndex > field.Length - 1 || ladyBugIndex < 0 || flyLength == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                while (field[ladyBugIndex] == 1)
                {
                    if (destinationIndex > field.Length - 1)
                    {
                        field[ladyBugIndex] = 0;

                    }
                    else if (destinationIndex < 0)
                    {
                        field[ladyBugIndex] = 0;

                    }
                    else if (field[destinationIndex] == 0)
                    {
                        field[destinationIndex] = 1;
                        field[ladyBugIndex] = 0;

                    }
                    else
                    {
                        if (destinationIndex > 0)
                        {
                            destinationIndex += flyLength;
                        }
                        else
                        {
                            destinationIndex -= flyLength;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}