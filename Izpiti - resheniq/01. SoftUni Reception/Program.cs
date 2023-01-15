using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstStudents = int.Parse(Console.ReadLine());
            int secondStudents = int.Parse(Console.ReadLine());
            int thirdStudents = int.Parse(Console.ReadLine());
            int countOfAllStudents = int.Parse(Console.ReadLine());

            int hours = 0;

            int allStudentsPerHour = firstStudents + secondStudents + thirdStudents;

            while (countOfAllStudents > 0)
            {
                countOfAllStudents -= allStudentsPerHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");


        }
    }
}
