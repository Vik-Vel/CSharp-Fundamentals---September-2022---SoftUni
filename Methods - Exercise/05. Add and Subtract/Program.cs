using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int result = Addd(one, two);
            Substract(result, three);

            // int total = ThirdSubtracts(one,two,three);
            // Console.WriteLine(total);

        }

        static void Substract(int result, int three) => Console.WriteLine(result-three);
        

        private static int Addd(int one, int two) => one + two;
        
        //static int OneAndTwo(int a, int b)
        //{
        //    int total = a + b;
        //    return total;
        //}

        //static int ThirdSubtracts(int a,int b,int c)
        //{

        //    int total = (a+b) - c;
        //    return total;
        //}
    }
}
