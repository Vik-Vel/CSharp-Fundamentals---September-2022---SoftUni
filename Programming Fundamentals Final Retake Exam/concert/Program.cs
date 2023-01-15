using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            int totalTime = 0;

            List<string> tokens = new List<string>();

            var bandsTime = new Dictionary<string, int>(); 
            var bands = new Dictionary<string, List<string>>();  

            while ((input = Console.ReadLine()) != "Start!")
            {
                tokens = input.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = tokens[0];
                string bandName = tokens[1];

                if (command == "Add")
                {
                    List<string> members = tokens[2].Split(", ").ToList(); 

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
                    totalTime += time;

                    if (!bandsTime.ContainsKey(bandName)) 
                    {
                        bandsTime.Add(bandName, time); 
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

            foreach (var kvp in bands)
            {
                Console.WriteLine(kvp.Key);
                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"=> {item}");
                    
                    }
                return;
            }
        }
    }
}