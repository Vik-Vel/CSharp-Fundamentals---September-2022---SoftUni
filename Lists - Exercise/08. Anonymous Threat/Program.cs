using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string commands = Console.ReadLine();

            while (commands != "3:1")
            {
                string[] tokens = commands.Split();
                string command = tokens[0];
                string splitWord = "";

                int startIndex = int.Parse(tokens[1]);
                int endIndex = int.Parse(tokens[2]);

                if (endIndex > myList.Count - 1 || endIndex < 0)
                {
                    endIndex = myList.Count - 1;
                }

                if (startIndex < 0 || startIndex > myList.Count - 1)
                {
                    startIndex = 0;
                }

                if (command == "merge")
                {
                    

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        splitWord += myList[i];
                    }

                    myList.RemoveRange(startIndex, endIndex - startIndex + 1);
                    myList.Insert(startIndex, splitWord);
                }

                else if (command == "divide")
                {
                    List<string> dividedList = new List<string>();
                    int partitions = int.Parse(tokens[2]);
                    string word = myList[startIndex];
                    myList.RemoveAt(startIndex);

                    int parts = word.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1) 
                        {
                            dividedList.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            dividedList.Add(word.Substring(i * parts, parts));
                        }
                    }
                    myList.InsertRange(startIndex, dividedList);
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
