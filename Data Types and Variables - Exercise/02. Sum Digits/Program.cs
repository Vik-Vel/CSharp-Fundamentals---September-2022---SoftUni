using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first
            string number = (Console.ReadLine());
            int newI = 0;
            int total = 0;
            int numm2 = int.Parse(number);

            for (int i = 1; i <= number.Length; i++)
            {
                newI = numm2 % 10;
                numm2 = numm2 / 10;
                total += newI;

            }
            Console.WriteLine(total);

            //second
            //int numInput = int.Parse(Console.ReadLine());
            //int finalSum = 0;

            //while(numInput != 0)
            //{
            //    int lastDigit = numInput % 10;
            //    finalSum += lastDigit;
            //    numInput /= 10;
            //}
            //Console.WriteLine(finalSum);

            //third
            //string input = Console.ReadLine();
            //char[] charArray = input.ToCharArray();
            //int finalSum = 0;

            //for (int value = 0; value < charArray.Length; value++)
            //{
            //    finalSum += int.Parse(charArray[value].ToString());
            //}

            //Console.WriteLine(finalSum);

            //fourth
            //string input = Console.ReadLine();
            //    int finalSum = 0;

            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        finalSum += int.Parse(input[i].ToString());
            //    }

            //    Console.WriteLine(finalSum);



        }
    }

}