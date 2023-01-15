using System;

namespace _12._Refactor_Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int all = 0;
            int currNum = 0;
            bool isSpecialNum = false;
           
            for (int i = 1; i <= input; i++)
            {
                currNum = i;

                while (i > 0)
                {
                    all += i % 10;
                    i /= 10;
                }
                if ( all == 5 || all == 7 || all == 11)
                {
                    isSpecialNum = true;
                    //Console.WriteLine("{0} -> {1}", currNum, isSpecialNum);
                    Console.WriteLine($"{currNum} -> True");
                }
                else
                {
                    isSpecialNum = false;
                    //Console.WriteLine("{0} -> {1}", currNum, isSpecialNum);
                    Console.WriteLine($"{currNum} -> False");
                }
                all = 0;
                i = currNum;




            }
        }
    }
}