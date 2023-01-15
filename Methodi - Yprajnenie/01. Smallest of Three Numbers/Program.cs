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

            Smalest(a,b,c);

        }

        static void Smalest(int a, int b, int c)
        {
            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
        }
    }
}
