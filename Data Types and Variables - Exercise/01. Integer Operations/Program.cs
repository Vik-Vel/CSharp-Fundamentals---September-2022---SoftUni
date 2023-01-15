using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firsNum = int.Parse(Console.ReadLine());
           int secondNum = int.Parse(Console.ReadLine());
           int thirdNum = int.Parse(Console.ReadLine());
           int fourtNum = int.Parse(Console.ReadLine());

            int operrationFirst = firsNum + secondNum;
            int operrationSecond = operrationFirst / thirdNum;
            int operrationThird = operrationSecond * fourtNum;


            Console.WriteLine(operrationThird);
        }
    }
}
