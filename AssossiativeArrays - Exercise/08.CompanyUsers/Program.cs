using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] companyArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = companyArgs[0];
                string employeeID = companyArgs[1];

                if (!employees.ContainsKey(companyName))
                {
                    employees.Add(companyName, new List<string>());
                }

                if (!employees[companyName].Contains(employeeID))
                {
                    employees[companyName].Add(employeeID);
                }
                
                command = Console.ReadLine();
            }

            foreach (var company in employees.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var IDs in company.Value)
                {
                    Console.WriteLine($"-- {IDs}");
                }
            }
        }
    }
}
