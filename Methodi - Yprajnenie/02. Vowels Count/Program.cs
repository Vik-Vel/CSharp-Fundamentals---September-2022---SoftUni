using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CountVowels(input);
        }

         static void CountVowels(string input)
        {
            int total = input.Count(vowles => "aouei".Contains(vowles));
            Console.WriteLine(total);
        }
    }
}
