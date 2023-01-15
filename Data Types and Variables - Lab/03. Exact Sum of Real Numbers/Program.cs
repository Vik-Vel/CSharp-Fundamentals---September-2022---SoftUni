using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            decimal total = 0;

            for(int i = 1; i <= numCount; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine(total);


        }
    }
}
