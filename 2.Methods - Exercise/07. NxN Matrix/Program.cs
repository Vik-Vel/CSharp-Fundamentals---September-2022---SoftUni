using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            Matrix(numbers);



        }

        private static void Matrix(int numbers)
        {
            for (int i = 0; i < numbers; i++)
            {
                for (int k = 0; k < numbers; k++)
                {
                    Console.Write(numbers + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
