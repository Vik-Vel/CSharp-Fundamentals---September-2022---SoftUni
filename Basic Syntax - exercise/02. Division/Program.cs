using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int maxDev = int.MinValue;
            if (input % 2 == 0 || input % 3 == 0 || input % 6 == 0 || input % 7 == 0 || input % 10 == 0)

            {
                if (input % 2 == 0)
                {
                    maxDev = 2;
                }
                if (input % 3 == 0)
                {
                    maxDev = 3;
                }
                if (input % 6 == 0)
                {
                    maxDev = 6;
                }
                if (input % 7 == 0)
                {
                    maxDev = 7;
                }
                if (input % 10 == 0)
                {
                    maxDev = 10;
                }
                Console.WriteLine($"The number is divisible by {maxDev}");
            }


            else
            {
                Console.WriteLine("Not divisible");
            }











        }
    }
}
