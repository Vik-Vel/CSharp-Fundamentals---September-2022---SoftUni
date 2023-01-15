using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"\|(?<name>[A-Z]{4,})\|\:\#(?<title>[A-Za-z]+\s[A-Za-z]+)\#");
                Match mach = regex.Match(input);

                if (mach.Success)
                {
                    var name = mach.Groups["name"].Value;


                    var title = mach.Groups["title"].Value;


                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }

                else
                {
                    Console.WriteLine("Access denied!");

                }


            }

        }

    }
}