using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentProps = command.Split(' ');

                string firstName = studentProps[0];
                string lastName = studentProps[1];
                int age = int.Parse(studentProps[2]);
                string homeTown = studentProps[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    GetStudent(students, firstName, lastName, age);
                }

                else
                {
                    Student student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown,

                    };

                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string town = Console.ReadLine();

            List<Student> filteredStudents = students.Where(s => s.HomeTown == town).ToList();

            foreach (var student in filteredStudents)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is { student.Age } years old.");
                }
            }

        }
        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static void GetStudent(List<Student> students, string firstName, string lastName, int age)
        {

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = student.HomeTown;

                }
            }

        }
    }


    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
