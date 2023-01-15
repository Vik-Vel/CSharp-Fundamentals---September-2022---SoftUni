using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, string> dic = new Dictionary<string, string>();


            dic.con

















            
            //---------------------------------------

            //string pattern = @"(@|#)(?<word>[A-Za-z]{3,})\1{2}(?<mirrorWord>[A-Za-z]{3,})\1";

            //string input = Console.ReadLine();

            //Regex regex = new Regex(pattern);

            //MatchCollection matches = regex.Matches(input);

            //List<string> words = new List<string>();
            //List<string> mirrWords = new List<string>();

            
            //foreach (Match match in matches)
            //{
            //    string word = match.Groups["word"].Value;
            //    string mirrWord = match.Groups["mirrorWord"].Value;

            //    words.Add(word);
            //    mirrWords.Add(mirrWord);

            //}

            //List<string> result = new List<string>();

            //foreach (var w in words)
            //{
            //    foreach (var o in mirrWords)
            //    {
            //        string currW = string.Empty;
            //        for (int i = o.Length - 1; i >= 0; i--)
            //        {
            //            currW += o[i];
            //        }
            //        if (w == currW)
            //        {
            //            result.Add($"{w} <=> {o}");
            //        }


            //    }
            //}
            //if (matches.Count == 0)
            //{
            //    Console.WriteLine("No word pairs found!");
            //}
            //if (matches.Count > 0)
            //{
            //    Console.WriteLine($"{matches.Count} word pairs found!");
            //}
            //if (result.Count == 0)
            //{
            //    Console.WriteLine("No mirror words!");
            //}
            
            //if (result.Count > 0)
            //{
            //    Console.WriteLine($"The mirror words are:");
            //    Console.WriteLine($"{string.Join(", ", result)}");
            //}
            
            
        



        //-----------------------------------------------

        //string input = Console.ReadLine();

        //string pattern = @"\#{1}[A-z]{3,}\#{2}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2}[A-z]{3,}\@{1}";

        //Regex regex = new Regex(pattern);

        //List<string> words = new List<string>();
        //List<string> mirrorWords = new List<string>();

        //MatchCollection matches = regex.Matches(input);


        //foreach (Match match in matches)
        //{

        //    words.Add(match.ToString());
        //}

        //for (int i = 0; i < words.Count; i++)
        //{
        //    string current = words[i];
        //    string firstHalf = "";
        //    string secondHalf = "";



        //    for (int j = 0; j < current.Length/2; j++)
        //    {
        //        firstHalf += current[j];
        //    }

        //    for (int k = current.Length - 1; k >= current.Length/2; k--)
        //    {
        //        secondHalf += current[k];
        //    }


        //    if (firstHalf == secondHalf)
        //    {
        //        mirrorWords.Add(current);
        //    }
        //}

        //if (words.Count > 0 )
        //{
        //    Console.WriteLine($"{words.Count} word pairs found!");
        //}
        //else
        //{
        //    Console.WriteLine("No word pairs found!");
        //}


        //List<string> final = new List<string>();

        //if (mirrorWords.Count > 0)
        //{
        //    Console.WriteLine("The mirror words are:");
        //    string final1 = "";

        //    foreach (var item in mirrorWords)
        //    {
        //        var curritem = item.Substring(1, (item.Length / 2) - 2);
        //        var curritem1 = item.Substring(item.Length / 2 + 1, (item.Length - ((item.Length / 2) + 2)));

        //        final1 = $"{curritem} <=> {curritem1}";
        //        final.Add(final1);
        //    }

        //    Console.WriteLine($"{string.Join(", ", final)}");
        //}
        //else
        //{
        //    Console.WriteLine("No mirror words!");
        //}

    }
}
}
