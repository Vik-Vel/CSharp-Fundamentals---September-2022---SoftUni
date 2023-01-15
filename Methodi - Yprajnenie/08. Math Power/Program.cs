using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = MathPower(@base,power);
            Console.WriteLine(result);
        }

         static double MathPower(double a, double b)
        {
            double result = 0;

            result = Math.Pow(a,b);

           return result;
        }
        
    }
}
