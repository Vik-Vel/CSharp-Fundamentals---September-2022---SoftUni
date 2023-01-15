using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()); 
            int fromHowMuch = int.Parse(Console.ReadLine());

            for (int i = fromHowMuch; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }






















            //int input = int.Parse(Console.ReadLine());
            //int input2 = int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine($"{input} X {input2} = {input * input2}");
            //    input2++;
            //} while (input2 <= 10);
           


        }
    }
}
