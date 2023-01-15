using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;
                for (int indexLeft = i; indexLeft > 0; indexLeft--)
                {
                    int nextElemPosition = indexLeft - 1;
                    rightSum += indexLeft + 1;
                    if (indexLeft > 0) 
                    {
                        leftSum += numbers[nextElemPosition];
                    }
                   
                }

                rightSum = 0;
                for (int j = i; j <numbers.Length; j++)
                {
                    int nextElemPosition = j + 1;
                    if (j < numbers.Length - 1)  
                    {
                        rightSum += numbers[nextElemPosition];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
