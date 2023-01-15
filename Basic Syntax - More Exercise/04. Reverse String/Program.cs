using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string words = Console.ReadLine();
            string reverseWord = null;

            for (int i = words.Length-1; i >= 0 ; i--)
            {
                reverseWord += words[i]; ;
            }
            Console.WriteLine(reverseWord);
        }
    }
}
