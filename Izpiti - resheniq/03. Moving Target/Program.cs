using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] tokens = commands.Split();

                string nameOfComand = tokens[0];
                int index = int.Parse(tokens[1]);

                if (nameOfComand == "Shoot")
                {
                    int power = int.Parse(tokens[2]);
                    Shoot(targets, index, power);
                }

                else if (nameOfComand == "Add")
                {
                    int value = int.Parse(tokens[2]);
                    Add(targets, index, value);
                }

                else if (nameOfComand == "Strike")
                {
                    int radius = int.Parse(tokens[2]);
                    Strike(targets, index, radius); // погледни май не е рейндж трябва да маха колкото радиуса отпред и отзад
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }


        static void Shoot(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                if (targets[index] > power)
                {
                    targets[index] -= power;
                }
                else
                {
                    targets.RemoveAt(index);
                }
            }
        }

        static void Add(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                
                    targets.Insert(index,value);
                
            }
            else
            {
                Console.WriteLine("Invalid placement!");

            }
        }

        static void Strike(List<int> targets, int index, int radius)
        {
            int start = index - radius;
            int end  = index + radius;

            if (start >= 0 && end < targets.Count)
            {
                targets.RemoveRange(start, end - start + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }
    }
}
