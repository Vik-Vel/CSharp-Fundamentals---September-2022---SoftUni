using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Concert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandsTime = new Dictionary<string, int>();

            string input = string.Empty;

            int totalTime = 0;

            while ((input = Console.ReadLine()) != "Start!")
            {
                string[] tokens = input.Split("; ",StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string bandName = tokens[1];

                if (command == "Add")
                {
                    List<string> members = tokens[2].Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (!bands.ContainsKey(bandName))
                    {
                        bands.Add(bandName, new List<string>());
                        

                    }
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (!bands[bandName].Contains(members[i]))
                        {
                            bands[bandName].Add(members[i]);
                        }

                    }
                }
                else if (command == "Play")
                {
                    int time = int.Parse(tokens[2]);
                    if (time < 0)
                    {
                        time = 0;
                    }
                    totalTime += time;

                    if (!bandsTime.ContainsKey(bandName))
                    {
                        bandsTime.Add(bandName, time);
                        if (!bands.ContainsKey(bandName))
                        {
                            bands.Add(bandName, new List<string>());
                        }
                    }

                    else
                    {
                        bandsTime[bandName] += time;
                    }
                }

            }

            Console.WriteLine($"Total time: {totalTime} ");
            foreach (var item in bandsTime)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var band in bands)
            {
                Console.WriteLine(band.Key);

                foreach (var item in band.Value)
                {
                    Console.WriteLine($"=> {item}");

                }
                return;
            }

            
        }

    }
}

