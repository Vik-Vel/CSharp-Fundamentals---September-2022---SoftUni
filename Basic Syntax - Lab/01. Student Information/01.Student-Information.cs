using System;

namespace _01._Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studName}, Age: {age}, Grade: {grade:f2}");






















            //string studentName = Console.ReadLine();
            //int studentAge = int.Parse(Console.ReadLine());
            //double studentGrade = double.Parse(Console.ReadLine());


            //Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentGrade:f2}");





        }
    }
}
