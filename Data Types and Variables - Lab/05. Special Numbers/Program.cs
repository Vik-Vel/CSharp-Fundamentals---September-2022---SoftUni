﻿using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());   

            for(int i = 1; i <= input; i++)
            {
                int sum = 0;
                int currentNum = i;

                while(currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                    
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
         


        }
    }
}