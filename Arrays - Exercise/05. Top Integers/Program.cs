using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentIterationNum = inputArray[i];
                bool currInterattionNumIsBigger = true;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    int nextIterationNum = inputArray[j];
                    if (currentIterationNum <= inputArray[j])
                    {
                        currInterattionNumIsBigger = false;
                        break;
                    }
                }

                if (currInterattionNumIsBigger)
                {
                    Console.Write($"{currentIterationNum} ");
                }
            }




        }
    }
}
