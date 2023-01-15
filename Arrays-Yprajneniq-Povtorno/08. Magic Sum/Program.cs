using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            string numberWhoAre = string.Empty;
            int sum = 0;

            for (int firstNum = 0; firstNum < numbers.Length-1; firstNum++)
            {
                for (int secondNum = firstNum +1 ; secondNum < numbers.Length; secondNum++)
                {
                    if (numbers[firstNum] + numbers[secondNum] == magicNum)
                    {
                        Console.Write($"{numbers[firstNum]} {numbers[secondNum]} ");
                        Console.WriteLine();
                    }
                }
            }
            

        }
    }
}
