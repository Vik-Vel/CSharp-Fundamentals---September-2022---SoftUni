using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumOfOdds = 0;
            int sumOfEvens = 0;
            int total = 0;


           
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 ==0)
                {
                    sumOfEvens += currentNumber;
                }
                else
                {
                    sumOfOdds += currentNumber;
                }
            }
            total = sumOfEvens - sumOfOdds;
            Console.WriteLine(total);




        }
    }
}
