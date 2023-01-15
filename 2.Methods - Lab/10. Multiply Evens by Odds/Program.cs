using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);


        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            int digit = number;
            while (digit > 0)
            {
                int currDigit = digit % 10;
                if (currDigit % 2 != 0)
                {
                    evenSum += currDigit;
                }
                digit = digit / 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {

            int oddSum = 0;
            int digit = number;
            while (digit > 0)
            {
                int currDigit = digit % 10;
                if (currDigit % 2 == 0)
                {
                    oddSum += currDigit;
                }
                digit = digit / 10;
            }
            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int result = evenSum * oddSum;
            return result;

        }
    }
}
