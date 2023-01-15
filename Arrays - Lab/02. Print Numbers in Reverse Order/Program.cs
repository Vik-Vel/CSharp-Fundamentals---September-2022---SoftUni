using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            int[] numbers = new int[numOfInputs];

            for (int i = 0; i < numOfInputs; i++)
            {
               numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length-1; i >= 0 ; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
























            //int length = int.Parse(Console.ReadLine());
            //int[] numbers = new int[length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i]= int.Parse(Console.ReadLine());

            //}
            //for (int i = numbers.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}







        }
    }
}
