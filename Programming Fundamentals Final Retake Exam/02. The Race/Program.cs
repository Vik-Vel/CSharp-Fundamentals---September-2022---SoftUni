using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._The_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\#|\$|\%|\*|\&)(?<name>[A-Za-z]+)\1\=(?<length>[0-9]+)!!(?<code>(?<=!!).*)";
                //@"(\#|\$|\%|\*|\&)(?<name>[A-Za-z]+)\1\=(?<length>[0-9]+)!!(?<code>[A-Za-z0-9]+)"

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            bool matchFound = false;

            while (!matchFound)
            {
                matchFound = false;
                MatchCollection matches = regex.Matches(input);

                List<string> result = new List<string>();

                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    int lenght = int.Parse(match.Groups["length"].Value);
                    string code = match.Groups["code"].Value;
                    string newCode = "";

                    if (lenght == code.Length)
                    {
                        for (int i = 0; i < code.Length; i++)
                        {
                            int ch = code[i] + lenght;
                            newCode += (char)ch;

                        }

                        Console.WriteLine($"Coordinates found! {name} -> {newCode}");
                        matchFound = true;
                        return;
                    }
                   
                }
                Console.WriteLine("Nothing found!");
                input = Console.ReadLine();
            }


        }
    }
}
