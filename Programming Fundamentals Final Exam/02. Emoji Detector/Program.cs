using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {






















            //--------------------------------

           // string input = Console.ReadLine();

           // string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
           // string numberPattern = @"(?<number>[0-9])";

           //Regex numberRegex = new Regex(numberPattern);
           // Regex emojiRegex = new Regex(emojiPattern);

           // MatchCollection emojiMatches = emojiRegex.Matches(input);
           // MatchCollection numberMatches = numberRegex.Matches(input);

           // int coolTotal = 0;
            
           // List<int> nums = new List<int>();

           // foreach (Match num in numberMatches)
           // {
           //     int cool = int.Parse(num.ToString());

           //     nums.Add(cool);
           // }

           // if (nums.Count >= 2)
           // {

           //     for (int i = 0; i < nums.Count; i++)
           //     {
           //         if (i == 0)
           //         {
           //             coolTotal = nums[i] * nums[i + 1];
           //             i++;
           //         }
           //         else
           //         {
           //             coolTotal *= nums[i];
           //         }
           //     }
           // }
           // else
           // {
           //     coolTotal = nums.Sum();
           // }
            

           // var emojiList = new Dictionary<string, int>();

           

           // foreach (Match item in emojiMatches)
           // {
           //     string emoji = item.Groups["emoji"].Value;

           //     char[] letters = emoji.ToCharArray();

           //     int number = letters.Sum(x=>(int)x);

           //     string trueEmoji = item.ToString();

           //     if (!emojiList.ContainsKey(trueEmoji))
           //     {
           //         emojiList.Add(trueEmoji, number);
           //     }
           // }
           // Console.WriteLine($"Cool threshold: {coolTotal}");

           // if (emojiList.Any())
           // {
           //     Console.WriteLine($"{emojiList.Count} emojis found in the text. The cool ones are:");

           //     foreach(var(name,number) in emojiList)
           //     {
           //         if (number>coolTotal)
           //         {
           //             Console.WriteLine($"{name}");
           //         }
           //     }
           // }



            //--------------------------------------

            //string input = Console.ReadLine();
            //string numberPattern = @"(?<number>[0-9])";
            //string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";


            //Regex emojiRegex = new Regex(emojiPattern);
            //Regex numberRegex = new Regex(numberPattern);

            //MatchCollection numberMatches = numberRegex.Matches(input);

            //MatchCollection emojiMatches = emojiRegex.Matches(input);

            //var numbers = new List<int>();
            //int coolnes = 0;


            //foreach (Match match in numberMatches)
            //{
            //     int number = int.Parse(match.ToString());

            //    numbers.Add(number);
            //}

            //int coolTotal = 0;

            //if (numbers.Count >= 2)
            //{
            //    for (int i = 0; i < numbers.Count; i++)
            //    {
            //        if (i == 0)
            //        {
            //            coolTotal += numbers[i] * numbers[i + 1];
            //            i++;
            //        }
            //        else
            //        {
            //            coolTotal *= numbers[i];
            //        }
            //    }
            //}
            //else
            //{
            //    coolTotal = numbers.Sum();
            //}

            //var emojiList = new Dictionary<string, int>();

            //foreach (Match match in emojiMatches)
            //{
            //    //izchistva dumata ot nenujni znaci
            //    string emoji = match.Groups["emoji"].ToString();
            //    char[] letters = emoji.ToCharArray();

            //    int number = letters.Sum(x => (int)x);

            //    string trueEmoji = match.ToString();

            //    if (!emojiList.ContainsKey(trueEmoji))
            //    {
            //        emojiList.Add(trueEmoji,number);
            //    }
            //}

            //Console.WriteLine($"Cool threshold: {coolTotal}");

            //if (emojiList.Any())
            //{
            //    Console.WriteLine($"{emojiList.Count} emojis found in the text. The cool ones are:");
            //    foreach (var (name, number) in emojiList)
            //    {
            //        if (number > coolTotal)
            //        {
            //            Console.WriteLine($"{name}");
            //        }
            //    }
            //}

        }
    }
}
