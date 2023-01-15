using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numberIs();
        }

        static void numberIs()
        {
            int input = int.Parse(Console.ReadLine());

            if(input > 0 )
            {
                Console.WriteLine($"The number {input} is positive. ");
            }
           else if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {input} is zero. ");
            }

        }
    }
}
