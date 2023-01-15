using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());

            string result = RepeatStr(letters,repeatTimes);
            Console.WriteLine(result);
        }

        static string RepeatStr(string lett, int repeat)
        {
            string result = string.Empty;
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(lett);
            }
            return result;
        }

    }

}
