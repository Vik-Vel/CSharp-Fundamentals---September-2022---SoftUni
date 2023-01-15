using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhoods = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string input = Console.ReadLine();

            int lastIndex = 0;
            int index = 0;

            
            while (input != "Love!")
            {
                string[] tokens = input.Split();

                //lastIndex = index;
                 index = int.Parse(tokens[1]);
                //index = neighborhoods[0];

                int currIndex = lastIndex + index;

                if (currIndex > neighborhoods.Count-1)
                {
                   //index += lastIndex;
                    currIndex = 0;
                    //lastIndex = 0;

                }
              
                if (neighborhoods[currIndex] > 0)
                {
                    //index += lastIndex;
                    neighborhoods[currIndex] -= 2;

                    if (neighborhoods[currIndex] == 0)
                    {
                        Console.WriteLine($"Place {currIndex} has Valentine's day.");
                        goto Found;
                    }
                }
                else 
                {
                    Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                }


            Found:
                lastIndex = currIndex;
                input = Console.ReadLine();
            }
            //int countFails = 0;
            //for (int i = 0; i < neighborhoods.Count; i++)
            //{
            //    if (neighborhoods[i] != 0)
            //    {
            //        countFails++;
            //    }
            //}
            Console.WriteLine($"Cupid's last position was {lastIndex}.");

            if (neighborhoods.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
               
            }
            else
            {
                int countFails = neighborhoods.Count(points => points > 0);
                Console.WriteLine($"Cupid has failed {countFails} places.");
            }


        }
    }
}
