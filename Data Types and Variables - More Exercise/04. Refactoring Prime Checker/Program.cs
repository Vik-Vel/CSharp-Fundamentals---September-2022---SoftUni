using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isNumberPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isNumberPrime = false;
                        break;
                    }
                }
                string lower = $"{i} -> {isNumberPrime}".ToLower();
                Console.WriteLine(lower);





            }
        }
    }
}