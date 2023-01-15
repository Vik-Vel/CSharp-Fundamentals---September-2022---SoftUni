using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(' ');

            foreach (string word in arrOne)
            {
                
                        Console.Write($"{word} ");
                  
            }



        }
    }
}
