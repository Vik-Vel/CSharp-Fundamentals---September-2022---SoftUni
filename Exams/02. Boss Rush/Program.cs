using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(':');
                string bossName = tokens[0];
                string bossTitle = tokens[1];

                int valid = 0;
                int notValid = 0;
                string name = "";
                int strenght = 0;
                if (bossName[0] == '|' && bossName[bossName.Length - 1] == '|')
                {
                    if (bossName.Length >= 4)
                    {
                        for (int k = 1; k < bossName.Length - 1; k++)
                        {
                            char ch = bossName[k];

                            if (!char.IsUpper(ch) && !char.IsLetter(ch))
                            {
                                Console.WriteLine("Access denied!");
                                notValid++;
                                break;
                            }

                        }
                    }
                    valid++;

                    for (int p = 1; p < bossName.Length - 1; p++)
                    {
                        name += bossName[p];
                        strenght++;
                    }
                }
                int armor = 0;
                string titleOne = "";
                string titleTwo = "";

                if (bossTitle[0] == ' ')
                {
                    Console.WriteLine("Access denied!");
                    notValid++;
                    break;
                }
                if ( bossTitle[0] == '#' && bossTitle[bossTitle.Length - 1] == '#')
                {
                   
                    string[] words = bossTitle.Split();

                    if (words.Length > 2)
                    {
                        notValid++;
                        Console.WriteLine("Access denied!");
                        break;

                    }

                    for (int v = 1; v < words[0].Length - 1; v++)
                    {
                        char c = bossTitle[v];
                        if (!(c == ' ') && !char.IsLetter(c))
                        {
                            Console.WriteLine("Access denied!");
                            notValid++;
                            break;
                        }
                    }

                    armor = words[0].Length + words[1].Length - 1;
                    valid++;


                    for (int m = 1; m <= words[0].Length - 1; m++)
                    {
                        titleOne += words[0][m];
                    }
                    for (int q = 0; q <= words[1].Length - 2; q++)
                    {
                        titleTwo += words[1][q];
                    }
                }


                if (notValid == 0)
                {

                    Console.WriteLine($"{name}, The {titleOne} {titleTwo} ");
                    Console.WriteLine($">> Strength: {strenght}");
                    Console.WriteLine($">> Armor: {armor}");
                }

            

                
            }
        }
    }
}
//string splitPattern = @":";
// Regex regexSplit = new Regex(splitPattern);

//string[] input = Console.ReadLine().Split(':');
//string patternName = @"\|(?<name>[A-Z]{4,})\|";
//string patternTitle = @"#[A-Za-z]+\s[A-Za-z]+#";


//Regex regexTitle = new Regex(patternTitle);
//Regex regexName = new Regex(patternName);

//Match match = regexTitle.Match(input[0]);
//if (match.Success)
//{
//    int strenght = match.Length;
//}