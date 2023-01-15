using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] numbersArray = Console.ReadLine().Split(' ');
            double[] nums = new double[numbersArray.Length];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                nums[i] = double.Parse(numbersArray[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {(int)Math.Round(nums[i],MidpointRounding.AwayFromZero)}");

            }


        }
    }
}
