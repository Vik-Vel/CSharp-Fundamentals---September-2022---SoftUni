using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());


            if(Math.Abs(numA - numB) < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }






        }
    }
}
