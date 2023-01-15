using System;
using System.Collections.Generic;

namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            Dictionary <string,List<string>> allGuest = new Dictionary<string,List<string>>();
            int counterDislike = 0;
            while (input != "Stop")
            {
                string[] tokens = input.Split('-');

                string command = tokens[0];

                
                
                if (command == "Like")
                {
                    string guest = tokens[1];
                    string meal = tokens[2];

                    if (!allGuest.ContainsKey(guest))
                    {
                        allGuest.Add(guest, new List<string>());

                    }
                    if (!allGuest[guest].Contains(meal))
                    {
                        allGuest[guest].Add(meal);
                    }
                    
                }
                else if(command == "Dislike")
                {
                    string guest = tokens[1];
                    string meal = tokens[2];

                    if (allGuest.ContainsKey(guest))
                    {
                        if (allGuest[guest].Contains(meal))
                        {
                            counterDislike++;
                            allGuest[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else if (!allGuest[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var (guest, meal) in allGuest)
            {
                Console.WriteLine($"{guest}: {string.Join(", ",meal)}");
            }

            Console.WriteLine($"Unliked meals: {counterDislike}");
        }
    }
}
