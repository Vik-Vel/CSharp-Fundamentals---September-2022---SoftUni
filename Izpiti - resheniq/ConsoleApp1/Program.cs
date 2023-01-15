using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

           // bool targetShot = false;
            while (command == "End")
            {
                string[] tokens = command.Split();
                string nameOfComand = tokens[0];
                int index = int.Parse(tokens[1]);

                if (nameOfComand == "Shoot")
                {
                    int power = int.Parse(tokens[2]);
                    Shoot(targets, index, power);

                }





            }

        }

         static void Shoot(List <int> targets,int index, int power)
        {
            targets.RemoveRange(index, power);
            
        }
    }
}
