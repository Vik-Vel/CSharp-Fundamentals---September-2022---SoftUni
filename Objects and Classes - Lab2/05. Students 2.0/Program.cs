using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
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

                string firstName = studentProps[0];
                string lastName = studentProps[1];
                int age = int.Parse(studentProps[2]);
                string town = studentProps[3];

                Students student = studentsData.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student != null)
                {
                    student.HomeTown = town;
                    student.Age = age;
                }
                else
                {
                    student = new Students(
                        firstName,
                        lastName,
                        age,
                        town);

                    studentsData.Add(student);
                }

                command = Console.ReadLine();

            }
            string city = Console.ReadLine();


            foreach (var currentStudent in studentsData.Where(x =>x.HomeTown == city))
            {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                
            }
        }
                
            


        class Students
        {
            public Students(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }

 }

