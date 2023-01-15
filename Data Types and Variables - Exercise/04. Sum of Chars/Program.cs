using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= input; i++)
            {
                char digit = char.Parse(Console.ReadLine());  // превърщаме чар в число OT ASCII
                total += (int)digit; 
            }

            Console.WriteLine($"The sum equals: {total}");


        }
    }
}
