using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numOfPeople = int.Parse(Console.ReadLine());
            //int capacityOfElevator = int.Parse(Console.ReadLine());

            //int courses = (int)Math.Ceiling((double)numOfPeople/capacityOfElevator);
            //Console.WriteLine(courses);


            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double withReminderCourses = (double)persons / capacity;

            Console.WriteLine(Math.Ceiling(withReminderCourses));

        }
    }
}
