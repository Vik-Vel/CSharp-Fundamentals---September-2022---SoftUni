using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Palindrome(input);

           


        }

        private static void Palindrome(string input)
        {
           
            string first = string.Empty;
            string second = string.Empty;
            
            while (input != "END")
            {
                int newInput = int.Parse(input);

                for (int i = 0; i < input.Length; i++)
                {
                    first += input[i];
                }
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    second += input[i];
                }

                if (first == second)
                {
                    
                    Console.WriteLine("true");
                    
                }
                else
                {
                    Console.WriteLine("false");
                }

                first = string.Empty;
                second = string.Empty;
                input = Console.ReadLine();
            }

            //Console.WriteLine(isPalindrome);
            //Console.WriteLine("false");
        }
    }
}
