using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Smallest(a, b, c);
            Console.WriteLine(result);



        }

         static int Smallest(int a, int b, int c)
        {
            int y = Math.Min(a,Math.Min(b,c));

            return y;
        }
    }
}
