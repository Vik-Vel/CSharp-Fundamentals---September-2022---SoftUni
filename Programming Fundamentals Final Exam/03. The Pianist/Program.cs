using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


















            //-------------------------------------

            //Dictionary<string,List<string>> pieces = new Dictionary<string,List<string>>();

            //int n = int.Parse(Console.ReadLine());
            //string input = string.Empty;


            //for (int i = 0; i < n; i++)
            //{
            //    input = Console.ReadLine();

            //    string[] tokens = input.Split('|');

            //    string nameOfPiece = tokens[0];
            //    string composer = tokens[1];
            //    string key = tokens[2];

            //    if (!pieces.ContainsKey(nameOfPiece))
            //    {
            //        pieces.Add(nameOfPiece, new List<string>());
            //    }
            //    pieces[nameOfPiece].Add(composer);
            //    pieces[nameOfPiece].Add(key);

            //}

            //input = Console.ReadLine();

            //while (input != "Stop")
            //{
            //    string[] tokens = input.Split('|');

            //    string command = tokens[0];

            //    if (command == "Add")
            //    {
            //        string nameOfPiece = tokens[1];
            //        string composer = tokens[2];
            //        string key = tokens[3];

            //        if (!pieces.ContainsKey(nameOfPiece))
            //        {
            //            pieces.Add(nameOfPiece, new List<string>());
            //            pieces[nameOfPiece].Add(composer);
            //            pieces[nameOfPiece].Add(key);

            //            Console.WriteLine($"{nameOfPiece} by {composer} in {key} added to the collection!");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{nameOfPiece} is already in the collection!");
            //        }
                    
            //    }
            //    else if (command == "Remove")
            //    {
            //        string nameOfPiece = tokens[1];
            //        if (pieces.ContainsKey(nameOfPiece))
            //        {
            //            Console.WriteLine($"Successfully removed {nameOfPiece}!");
            //            pieces.Remove(nameOfPiece);
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Invalid operation! {nameOfPiece} does not exist in the collection.");
            //        }

            //    }
            //    else if (command == "ChangeKey")
            //    {
            //        string nameOfPiece = tokens[1];
            //        string newKey = tokens[2];

            //        if (pieces.ContainsKey(nameOfPiece))
            //        {
            //            pieces[nameOfPiece][1] = newKey;
            //            Console.WriteLine($"Changed the key of {nameOfPiece} to {newKey}!");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Invalid operation! {nameOfPiece} does not exist in the collection.");
            //        }
            //    }

            //    input = Console.ReadLine();
            //}


            //foreach (var (name,value) in pieces)
            //{
            //    Console.WriteLine($"{name} -> Composer: {value[0]}, Key: {value[1]}");
            //}




            //--------------------------------------------

            //    int n = int.Parse(Console.ReadLine());

            //    string input = string.Empty;

            //    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();


            //    for (int i = 0; i < n; i++)
            //    {
            //         input = Console.ReadLine();

            //        string[] tokens = input.Split('|');

            //        string piece = tokens[0];
            //        string composer = tokens[1];
            //        string key = tokens[2];

            //        if (!dictionary.ContainsKey(piece))
            //        {
            //            dictionary.Add(piece, new List<string>());
            //        }

            //        dictionary[piece].Add(composer);
            //        dictionary[piece].Add(key);

            //    }

            //    input = Console.ReadLine();

            //    while (input != "Stop")
            //    {
            //        string[] tokens = input.Split('|');

            //        string command = tokens[0];

            //        if (command == "Add")
            //        {
            //            string piece = tokens[1];
            //            string composer = tokens[2];
            //            string key = tokens[3];

            //            if (!dictionary.ContainsKey(piece))
            //            {
            //                dictionary.Add(piece, new List<string>());
            //                dictionary[piece].Add(composer);
            //                dictionary[piece].Add(key);

            //                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{piece} is already in the collection!");
            //            }
            //        }
            //        else if (command == "Remove")
            //        {
            //            string piece = tokens[1];
            //            if (dictionary.ContainsKey(piece))
            //            {
            //                dictionary.Remove(piece);
            //                Console.WriteLine($"Successfully removed {piece}!");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            //            }
            //        }

            //        else if(command == "ChangeKey")
            //        {
            //            string piece = tokens[1];
            //            string changeKey = tokens[2];

            //            if (dictionary.ContainsKey(piece))
            //            {
            //                dictionary[piece][1] = changeKey;



            //                Console.WriteLine($"Changed the key of {piece} to {changeKey}!");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            //            }
            //        }

            //        input = Console.ReadLine();

            //    }

            //    foreach (var (piece, value)  in dictionary)
            //    {
            //        Console.WriteLine($"{piece} -> Composer: {value[0]}, Key: {value[1]}");
            //    }

        }
    }
}
