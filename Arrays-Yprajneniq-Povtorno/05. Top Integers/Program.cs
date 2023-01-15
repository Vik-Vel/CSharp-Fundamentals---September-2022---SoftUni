using System;
using System.Linq;


namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)// 0=1
            {
                bool currInterationNumIsBigger = true;
                for (int j = i + 1; j < input.Length; j++) //0+1=1==>4
                {
                    if (input[i] <= input[j]) //1 <= 4? da
                    {
                        currInterationNumIsBigger = false; 
                        break;
                    }
                }
                if (currInterationNumIsBigger) //
                {
                    Console.Write($"{input[i]} ");
                }
            }

        }
    }
}
