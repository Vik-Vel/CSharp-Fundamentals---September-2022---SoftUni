﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            List<string> furniture = new List<string>();

            double totalPrice = 0;
            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(furnitureName);
                    totalPrice += price * quantity;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
