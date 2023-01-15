using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {























            //-----------------------------------------

            //string input = Console.ReadLine();

            //Dictionary <string, List<int>> cityes = new Dictionary<string, List<int>>();
            //while (input != "Sail")
            //{
            //    string[] tokens = input.Split("||");

            //    string nameOfCity = tokens[0];
            //    int population = int.Parse(tokens[1]);
            //    int gold = int.Parse(tokens[2]);


            //    if (!cityes.ContainsKey(nameOfCity))
            //    {
            //        cityes.Add(nameOfCity, new List<int>());
            //        cityes[nameOfCity].Add(population);
            //        cityes[nameOfCity].Add(gold);
            //    }
            //    else
            //    {
            //        cityes[nameOfCity][0] += population;
            //        cityes[nameOfCity][1] += gold;

            //    }
                
            //    input = Console.ReadLine();
            //}

            //input = Console.ReadLine();

            //while (input != "End")
            //{
            //    string[] tokens = input.Split("=>");

            //    string command = tokens[0];
            //    string nameOfCity = tokens[1];

            //    if (command == "Plunder")
            //    {
            //        int population = int.Parse(tokens[2]);
            //        int gold = int.Parse(tokens[3]);

            //        cityes[nameOfCity][0] -= population;
            //        cityes[nameOfCity][1] -= gold;

            //        if (cityes[nameOfCity][0] <= 0 || cityes[nameOfCity][1] <= 0)
            //        {
            //            Console.WriteLine($"{nameOfCity} plundered! {gold} gold stolen, {population} citizens killed.");
            //            Console.WriteLine($"{nameOfCity} has been wiped off the map!");
            //            cityes.Remove(nameOfCity);
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{nameOfCity} plundered! {gold} gold stolen, {population} citizens killed.");
            //        }
            //    }
            //    else if (command == "Prosper")
            //    {
            //        int gold = int.Parse(tokens[2]);

            //        if (gold < 0)
            //        {
            //            Console.WriteLine($"Gold added cannot be a negative number!");
            //        }
            //        else
            //        {
            //            cityes[nameOfCity][1] += gold;
            //            Console.WriteLine($"{gold} gold added to the city treasury. {nameOfCity} now has {cityes[nameOfCity][1]} gold.");
            //        }
            //    }


            //    input = Console.ReadLine();
            //}

            //if (cityes.Count > 0) 
            //{
            //    Console.WriteLine($"Ahoy, Captain! There are {cityes.Count} wealthy settlements to go to:");
            //    foreach (var (name,value) in cityes)
            //    {
            //        Console.WriteLine($"{name} -> Population: {value[0]} citizens, Gold: {value[1]} kg");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            //}

        }
    }
}
