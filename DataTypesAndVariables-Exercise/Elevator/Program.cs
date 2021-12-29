using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWhoNeedToElevate = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int courses = peopleWhoNeedToElevate / capacityOfElevator;
            int peopleLeft = peopleWhoNeedToElevate % capacityOfElevator;

            if (peopleLeft == 0)
            {
                courses = courses;
            }
            
            else if (peopleLeft <= capacityOfElevator)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
