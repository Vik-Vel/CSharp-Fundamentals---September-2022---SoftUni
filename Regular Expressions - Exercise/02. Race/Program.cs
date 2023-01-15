using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();

            string[] players = Console.ReadLine().Split(", ");

            foreach (string player in players)
            {
                if (!dict.ContainsKey(player))
                {
                    dict[player] = 0;
                }
            }
            string input = Console.ReadLine();
            string name = string.Empty;
            double distance = 0;

            while (input != "end of race")
            {
                string patternOne = @"[A-Za-z]";

                Regex regex = new Regex(patternOne);

                MatchCollection matches = regex.Matches(input);


                foreach (Match mach in matches)
                {
                    name+= mach.Value;
                }


                if (dict.ContainsKey(name))
                {
                    MatchCollection matchesForDistance = Regex.Matches(input, @"[0-9]");



                    foreach (Match item in matchesForDistance)
                    {
                        distance += double.Parse(item.Value);
                    }

                    dict[name] += distance;
                }

                input = Console.ReadLine();
            }

            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x=> x.Key,y => y.Value);

            int counter = 1;

            foreach (var kvp in dict)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                else
                {
                    break;
                }
                counter++;
            }
        }

    }
}

