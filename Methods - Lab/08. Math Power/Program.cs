using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double sum = 0;

            NumberOnPower(number,power,sum);

        }

        static void NumberOnPower(double number, double power, double sum)
        {
            sum = Math.Pow(number, power);
            Console.WriteLine(sum);


            //double sum = 1;
            //for (int i = 0; i < power; i++)
            //{
            //    sum += number;
            //}

            //return sum;
        }
    }
}
