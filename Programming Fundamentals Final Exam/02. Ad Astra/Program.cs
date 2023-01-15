using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
























            //-----------------------------------------

            //string input = Console.ReadLine();
            //string pattern = @"(\||\#)(?<product>[A-Za-z\s]+)\1(?<data>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";


            //Regex regex = new Regex(pattern);

            //MatchCollection matches = regex.Matches(input);

            //int totalCal = 0;
            //foreach (Match match in matches)
            //{
            //    int calories = int.Parse(match.Groups["calories"].Value);

            //    totalCal += calories;

            //}

            //Console.WriteLine($"You have food to last you for: {totalCal/2000} days!");
            //List<string> results = new List<string>();

            //foreach (Match item in matches)
            //{
            //    string prodName = item.Groups["product"].Value;
            //    string date = item.Groups["data"].Value;
            //    string cal = item.Groups["calories"].Value;

            //    results.Add($"Item: {prodName}, Best before: {date}, Nutrition: {cal}");
            //}

            //foreach (var prod in results)
            //{
            //    Console.WriteLine(prod);
            //}









            //---------------------------------------------

            //string input = Console.ReadLine();

            //string pattern = @"([#|\|])(?<food>[A-Za-z\s]+)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d{1,5})\1";

            //Regex regex = new Regex(pattern);

            //MatchCollection matches = regex.Matches(input);

            //int totalCalories = 0;

            //foreach (Match match in matches)
            //{
            //    int calories = int.Parse(match.Groups["calories"].Value);

            //    totalCalories += calories;
            //}

            //List<string> results = new List<string>();

            //foreach (Match item in matches)
            //{
            //    string food = item.Groups["food"].Value;
            //    string data = item.Groups["date"].Value;
            //    string cal = item.Groups["calories"].Value;

            //    results.Add($"Item: {food}, Best before: {data}, Nutrition: {cal}");

            //}

            //Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");

            //foreach (var prod in results)
            //{
            //    Console.WriteLine(prod);
            //}



            //---------------------------------------

            ///*•	It will be surrounded by "|" or "#" (only one of the two) in the following pattern: 
            //    #{item name}#{expiration date}#{calories}#   or 
            //    |{item name}|{expiration date}|{calories}|
            //        •	The item name will contain only lowercase and uppercase letters and whitespace
            //        •	The expiration date will always follow the pattern: "{day}/{month}/{year}", where the day, month, and year will be exactly two digits long
            //           •	The calories will be an integer between 0-10000
            // */

            //string input = Console.ReadLine();

            //string pattern = @"([#\|])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})*\1(?<calories>\d{1,5})\1";

            //MatchCollection matches = Regex.Matches(input, pattern);

            //int caloriesTotal = 0;

            //foreach (Match match in matches)
            //{
            //    int calories = (int.Parse)(match.Groups["calories"].Value);

            //    caloriesTotal += calories;
            //}

            //int days = caloriesTotal / 2000;

            //Console.WriteLine($"You have food to last you for: {days} days!");

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            //}







        }
    }
}
