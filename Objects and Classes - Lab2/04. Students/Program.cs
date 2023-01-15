using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentsData = new List<Students>();

           string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentProps = command.Split();
                Students student = new Students
                {
                    FirstName = studentProps[0],
                    LastName = studentProps[1],
                    Age = int.Parse(studentProps[2]),
                    HomeTown = studentProps[3],
                };

                studentsData.Add(student);

                command = Console.ReadLine();
            
            }
            string city = Console.ReadLine();


            foreach (var student in studentsData)
            {
                if (student.HomeTown == city) 
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }


        class Students
        {
            //public Students(string firstName, string lastName, int age, string homeTown)
            //{
            //    this.FirstName = firstName;
            //    this.LastName = lastName;
            //    this.Age = age;
            //    this.HomeTown = homeTown;
            //}


            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }


    }
}
