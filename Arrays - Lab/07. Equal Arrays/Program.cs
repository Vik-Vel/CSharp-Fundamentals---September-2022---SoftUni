using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersOne = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] numbersTwo = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int countDiff = 0;
            int total = 0;

            for (int i = 0; i < numbersOne.Length; i++)
            {
                if (numbersOne[i] != numbersTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                total+= numbersOne[i];
                
            }
            Console.WriteLine($"Arrays are identical. Sum: {total}");


        }
    }
}