using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            int counterMoves = 0;

            while (input != "end")
            {
                counterMoves++;
                string[] tokens = input.Split();

                int index1 = int.Parse(tokens[0]);
                int index2 = int.Parse(tokens[1]);

                if (index1 == index2 || index1 < 0 || index2 < 0 || index1 > numbers.Count-1 ||index2 > numbers.Count-1 )
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int averageIndex = numbers.Count / 2;
                    numbers.Insert(averageIndex, $"-{counterMoves}a");
                    numbers.Insert(averageIndex, $"-{counterMoves}a");
                }

                else
                {
                    
                    if (numbers[index1] == numbers[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[index1]}!");
                       if (index1 < index2)
                        {
                            numbers.RemoveAt(index1);
                            numbers.RemoveAt(index2 - 1);
                        }
                        else
                        {
                            numbers.RemoveAt(index1);
                            numbers.RemoveAt(index2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }


                }

                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {counterMoves} turns!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
