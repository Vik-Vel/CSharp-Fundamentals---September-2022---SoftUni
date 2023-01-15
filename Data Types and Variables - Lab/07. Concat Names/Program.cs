using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string sign = Console.ReadLine();
           

            Console.WriteLine($"{firstName}{sign}{lastName}");

        }
    }
}
