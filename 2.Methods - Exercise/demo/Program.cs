using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine()
               .Split()
               .ToList();

            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countCommands; i++)
            {
                string input = Console.ReadLine();

                string[] cmdArguments = input.Split();
                string command = cmdArguments[0];


                if (command == "Include")
                {
                    coffees.Add(cmdArguments[1]);
                }


                else if (command == "Remove")
                {
                    int value = int.Parse(cmdArguments[2]);
                    if (cmdArguments[1] == "first")
                    {
                        if (value >= coffees.Count && value <= 0)
                        {
                            continue;
                        }
                        coffees.RemoveRange(0, value);
                    }
                    else if (cmdArguments[1] == "last")
                    {
                        if (value >= coffees.Count && value <= 0)
                        {
                            continue;
                        }
                        coffees.RemoveRange(coffees.Count - 1, value);
                    }
                }

                else if (command == "Prefer")
                {
                    int index1 = int.Parse(cmdArguments[1]);//a
                    int index2 = int.Parse(cmdArguments[2]);//b

                    if (index1 < 0 && index1 >= coffees.Count || index2 < 0 && index2 >= coffees.Count || index1 == index2)
                    {
                        continue;
                    }
                    string index3;//c == a
                    index3 = coffees[index1];
                    coffees[index1] = coffees[index2]; // a == b
                    coffees[index2] = index3;


                }

                else if (command == "Reverse")
                {
                    coffees.Reverse();
                }

            }

            Console.WriteLine($"Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }
    }
}
