using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           int countVowels = CountVowels(input);
            Console.WriteLine(countVowels);
          
        }

         static int CountVowels(string input)
        {
            int count = 0;

            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
            foreach (char letter in input.ToLower()) //prevrushta vsichko v malki bukvi
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }
            return count;
        }


        //static void CountVowels(string input)
        //{
        //    int total = input.Count(vowles => "aAoOuUeEiI".Contains(vowles));
        //    Console.WriteLine(total);



        //}

    }
}
