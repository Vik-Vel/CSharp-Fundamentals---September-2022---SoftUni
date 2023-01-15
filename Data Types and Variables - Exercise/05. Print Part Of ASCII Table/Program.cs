using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= lastNum; i++)
            {
                
                Console.Write($"{(char)i} ");
            }


            //int firstNum = int.Parse(Console.ReadLine());
            //int lastNum = int.Parse(Console.ReadLine());

            //for (int i = firstNum; i <= lastNum; i++)
            //{
            //    char currentChar = (char)i;
            //    Console.Write($"{(char)i} ");
            //}
        }
    }
}
