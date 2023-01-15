using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
























            //------------------------------------------

            //Dictionary<string, List<double>> plantRaitings = new Dictionary<string, List<double>>();
            //Dictionary<string, int> plantRarities = new Dictionary<string, int>();

            //string input = string.Empty;
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //   input = Console.ReadLine();
            //    string[] tokens = input.Split("<->",StringSplitOptions.RemoveEmptyEntries);

            //    string plant = tokens[0];
            //    int rarity = int.Parse(tokens[1]);

            //    if (!plantRarities.ContainsKey(plant))
            //    {
            //        plantRarities.Add(plant, rarity);
            //        plantRaitings.Add(plant, new List<double>());
            //    }
            //    else
            //    {
            //        plantRarities[plant] = rarity;
            //    }
            //}
            //input = Console.ReadLine();

            //while (input != "Exhibition")
            //{
            //    string[] tokens = input.Split(new char[] {' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

            //    string command = tokens[0];
            //    string plant = tokens[1];

            //    if (command == "Rate")
            //    {
            //        double rating = double.Parse(tokens[2]);
            //        if (plantRaitings.ContainsKey(plant))
            //        {
            //            plantRaitings[plant].Add(rating);
            //        }
            //        else
            //        {
            //            Console.WriteLine("error");
            //        }
            //    }
            //    else if (command == "Update")
            //    {
            //        int newRrarity = int.Parse(tokens[2]);

            //        if (plantRarities.ContainsKey(plant))
            //        {
            //            plantRarities[plant] = newRrarity;
            //        }
            //        else
            //        {
            //            Console.WriteLine("error");
            //        }
            //    }
            //    else if(command == "Reset")
            //    {
            //        if (plantRaitings.ContainsKey(plant))
            //        {
            //           plantRaitings[plant].Clear();
            //        }
            //        else
            //        {
            //            Console.WriteLine("error");
            //        }
            //    }



            //    input = Console.ReadLine();
            //}

            //Console.WriteLine("Plants for the exhibition:");

            //foreach (var (plantName, rarity) in plantRarities)
            //{
            //    if (plantRaitings[plantName].Count > 0) 
            //    {
            //        double average = plantRaitings[plantName].Average();

            //        Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {average:f2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {0:f2}");
            //    }

                
            //}





            //----------------------------------------------------

            //Dictionary <string, List<double>> plantRaitings = new Dictionary<string, List<double>>();
            // Dictionary<string, int> plantRarities = new Dictionary<string, int>();

            // int n = int.Parse(Console.ReadLine());
            // string input;
            // for (int i = 0; i < n; i++)
            // {
            //      input = Console.ReadLine();

            //     string[] tokens = input.Split("<->", StringSplitOptions.RemoveEmptyEntries);

            //     string plant = tokens[0];
            //     int rarity = int.Parse(tokens[1]);

            //     if (!plantRarities.ContainsKey(plant))
            //     {
            //         plantRarities.Add(plant, rarity);
            //         plantRaitings.Add(plant, new List<double>());
            //     }
            //     else
            //     {
            //         plantRarities[plant] = rarity;
            //     }


            // }

            // input = Console.ReadLine();

            // while (input != "Exhibition")
            // {
            //     string[] tokens = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

            //     string command = tokens[0];
            //     string plant = tokens[1];



            //     if (command == "Rate")
            //     {
            //         double rating = double.Parse(tokens[2]);

            //         if (plantRaitings.ContainsKey(plant))
            //         {
            //             plantRaitings[plant].Add(rating);
            //         }
            //         else
            //         {
            //             Console.WriteLine("error");
            //         }
            //     }
            //     else if (command == "Update")
            //     {
            //         int rarity = int.Parse(tokens[2]);

            //         if (plantRaitings.ContainsKey(plant))
            //         {
            //             plantRarities[plant] = rarity;
            //         }
            //         else
            //         {
            //             Console.WriteLine("error");
            //         }
            //     }

            //     else if (command == "Reset")
            //     {
            //         if (plantRaitings.ContainsKey(plant))
            //         {
            //             plantRaitings[plant].Clear();
            //         }
            //         else
            //         {
            //             Console.WriteLine("error");
            //         }
            //     }


            //     input = Console.ReadLine();
            // }


            // Console.WriteLine("Plants for the exhibition:");




            // foreach (var (plant, rarity) in plantRarities)
            // {
            //     double average = plantRaitings[plant].Count > 0
            //         ? plantRaitings[plant].Average()
            //         : 0;

            //     Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {average:f2}");
            // }



        }
    }
}
