using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> final = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!final.ContainsKey(name))
                {
                    final.Add(name, new List<double>());
                }
                final[name].Add(grade);
            }

            foreach (var students in final.OrderByDescending(x => x.Value.Average()))
            {
                if (students.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{students.Key} -> {students.Value.Average():f2}");
                }
                
            }
        }
    }
}
