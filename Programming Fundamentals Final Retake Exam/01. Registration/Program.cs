using System;

namespace _01._Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string username = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Registration")
            {
                string[] tokens = input.Split();

                string command = tokens[0];

                if (command == "Letters")
                {
                    if (tokens[1] == "Lower")
                    {
                        username = username.ToLower();
                    }
                    else if (tokens[1] == "Upper")
                    {
                        username = username.ToUpper();
                    }
                    Console.WriteLine(username);
                }
                else if (command == "Reverse")
                {
                   int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex >= 0 && startIndex < username.Length && endIndex >= 0 && endIndex < username.Length )
                    {
                        string sub = username.Substring(startIndex, endIndex - startIndex+1);
                        string reversed = "";
                        for (int i = sub.Length - 1; i >= 0; i--)
                        {
                            reversed += sub[i];
                        }
                        Console.WriteLine(reversed);
                    }
                }
                else if (command == "Substring")
                {
                    string subs = tokens[1];
                    int index = username.IndexOf(subs);
                    if (username.Contains(subs))
                    {
                        username = username.Remove(index, subs.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The username {username} doesn't contain {subs}.");
                    }
                }
                else if(command == "Replace")
                {
                    char ch = char.Parse(tokens[1]);

                    username = username.Replace(ch, '-');
                    Console.WriteLine(username);
                }
                else if (command == "IsValid")
                {
                    char ch = char.Parse(tokens[1]);
                    if (username.Contains(ch))
                    {
                        Console.WriteLine($"Valid username.");
                    }
                    else
                    {
                        Console.WriteLine($"{ch} must be contained in your username.");
                    }
                }
                input = Console.ReadLine();
            }




        }
    }
}
