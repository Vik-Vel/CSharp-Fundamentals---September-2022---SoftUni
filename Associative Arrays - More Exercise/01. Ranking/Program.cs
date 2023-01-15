using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ranklist = new Dictionary<string, string>();


            string input = Console.ReadLine();

            while (input != "end of contest")
            {
                string[] tokens = input.Split(":");
                
                string nameOfCourse = tokens[0];
                string pass = tokens[1];

                if (!ranklist.ContainsKey(nameOfCourse))
                {
                    ranklist.Add(nameOfCourse, pass);
                    //ranklist[nameOfCourse] = pass;
                }
                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> submission = new Dictionary<string, Dictionary<string, int>>();

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] tokens =input.Split("=>");

                string nameOfCourse = tokens[0];
                string pass = tokens[1];
                string name = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!submission.ContainsKey(name))
                {
                    if(submission.ContainsKey(pass) == ranklist.Contains()
                    {

                    }
                    submission.Add(nameOfCourse,)
                }
            }
        }
    }
}
