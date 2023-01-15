using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            
            Console.WriteLine(SmalestNumber(one,two,three));
            //PrintSmalestNumber(one, two, three);
        }

        static int SmalestNumber(int a, int b, int c)
        {
            
            return Math.Min(a, Math.Min(b,c));
            
        }

        //static void PrintSmalestNumber(int a, int b, int c) => Console.WriteLine(Math.Min(a,Math.Min(b,c)));
    }
}
