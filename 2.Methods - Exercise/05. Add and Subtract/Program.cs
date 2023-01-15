using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            //Sum(first, second);
            //Substract();
            int result = Sum(first,second) - Substract(third);
            Console.WriteLine(result);
        }

         static int Substract(int third)
        {
            return third;
        }

         static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
