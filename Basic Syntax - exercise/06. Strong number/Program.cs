using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strongNumber = int.Parse(Console.ReadLine());
            int strongNumberCopy = strongNumber;
            int sum = 0;

            while (strongNumber > 0 )
            {
                int factorialNumber = 1;
                int currNumber = strongNumber % 10;
                strongNumber /= 10;

                for (int i = 2; i <= currNumber; i++)
                {
                    factorialNumber *= i;
                }

                sum += factorialNumber;
            }

            Console.WriteLine(sum == strongNumberCopy? "yes" : "no");





            //string number = Console.ReadLine(); //пишем стринг за да ни е по-лесно да взимаме цифрите

            //long factorialSum = 0; //пишем лонг защото ще бъде дълго числото(по-приемливо за конзолата)

            //for (int i = 0; i <= number.Length - 1; i++) //            for(int i = 0; i < number.Length; i++) -> същото
            //{
            //    char currCh = number[i];
            //    int currDigit = (int)currCh - 48;// взимаме го от ASCII, всеки символ отговаря на число

            //    long currDigitFactorial = 1;
            //    for (int r = currDigit; r > 1; r--)
            //    {
            //        currDigitFactorial *= r;
            //    }
            //    factorialSum += currDigitFactorial;
            //}

            //if (factorialSum == int.Parse(number))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
        }
    }
}
