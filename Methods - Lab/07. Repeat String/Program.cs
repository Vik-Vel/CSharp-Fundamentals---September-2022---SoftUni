using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int howManyTimes = int.Parse(Console.ReadLine());

            RepeatString(input, howManyTimes);

        }

        static void RepeatString(string input, int howManyTimes)
        {
            for (int i = 1; i <= howManyTimes; i++)
            {
                Console.Write(input);
            }
        }
    }
}
