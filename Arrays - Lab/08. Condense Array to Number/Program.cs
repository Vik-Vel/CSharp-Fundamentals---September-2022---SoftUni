using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = input.Length;

            while (counter > 1)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i] + input[i + 1];
                }
                counter--;
            }
            Console.WriteLine(input[0]);



            //int[] nums = Console.ReadLine()
            //     .Split()
            //     .Select(int.Parse)
            //     .ToArray();

            // int[] condensed  = new int[nums.Length-1];

            // if (nums.Length == 1)
            // {
            //     Console.WriteLine(nums[0]);
            //     return;
            // }
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     for (int j = 0; j < condensed.Length - 1; j++)
            //     {
            //         condensed[j] = nums[j] + nums[j + 1];
            //     }
            //     nums = condensed;
            // }
            // Console.WriteLine(condensed[0]);
        }
    }
}
