﻿using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNum; i++)
            {
                PrintLine(1,i);

            }

            for (int i  = endNum -1; i >=  1; i--)
            {
                PrintLine(1, i);
            }


        }

         static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
