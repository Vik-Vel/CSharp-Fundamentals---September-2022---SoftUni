using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            
            PrintTopNumbersUpTo(number);

           

        }
        private static void PrintTopNumbersUpTo(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (OneDigit(i) && Divisible8(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool OneDigit(int number)
        {
            int countOdd = 0;
            
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }

            return false;

        }

         static bool Divisible8(int number)
        {
            int sumOfDigits = 0;
            //string num = number.ToString();
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
           
            return false;
        }
    }
}
