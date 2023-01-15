using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            double resultOne = Factorial(numOne);
            double resultTwo = Factorial(numTwo);

            Console.WriteLine($"{resultOne / resultTwo:f2}");
          



        }

        private static double Factorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }

        //private static int Divided(int numOne, int numTwo)
        //{

        //}
    }
}
