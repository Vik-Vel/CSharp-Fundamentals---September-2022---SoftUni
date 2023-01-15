using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            SearchForVoweles(inputText);

        }

        static void SearchForVoweles(string text)
        {
            int count = 0;
            Console.WriteLine(text.Count(vowles => "aouei".Contains(vowles)));

        }
    }
}
