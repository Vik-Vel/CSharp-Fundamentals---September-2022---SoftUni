using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrOne.Length; i++)
            {
                for (int j = 0; j < arrTwo.Length; j++)
                {
                    if (arrOne[i] == arrTwo[j])
                    {
                       Console.Write($"{arrTwo[j]} ");
                        //Console.Write(string.Join(' ', arrTwo[j]));
                    }
                }
            }



        }
    }
}
