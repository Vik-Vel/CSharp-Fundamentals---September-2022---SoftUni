using System;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                string numbers = Console.ReadLine();

               // char distanceBetween = ' ';

                string[] splitNumbers = numbers.Split(' ');

                long leftNumber = long.Parse(splitNumbers[0]);
                long rightNumber  = long.Parse(splitNumbers[1]);

                long bigestNum = rightNumber;

                if (leftNumber > rightNumber)
                {
                    bigestNum = leftNumber;
                }

                long sumOfDigits = 0;
                while (bigestNum !=0)
                {
                    sumOfDigits += bigestNum % 10;
                    bigestNum /= 10;
                }
                Console.WriteLine(sumOfDigits);
            }

            

























            //int numOfStrings = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= numOfStrings; i++)
            //{
            //    string numbers = Console.ReadLine();

            //    char delimiter = ' ';   //разделител

            //    string[] splitNumbers = numbers.Split(delimiter);

            //    long leftNum = long.Parse(splitNumbers[0]);
            //    long rightNum = long.Parse(splitNumbers[1]);

            //    long biggerNumber = rightNum;
            //    if(leftNum > rightNum)
            //    {
            //        biggerNumber = leftNum;
            //    }

            //    long sumOfDigits = 0;
            //    while (biggerNumber != 0)
            //    {
            //        sumOfDigits += biggerNumber % 10;
            //        biggerNumber /= 10;
            //    }
            //    Console.WriteLine(Math.Abs(sumOfDigits));

            //}






        }
    }
}
