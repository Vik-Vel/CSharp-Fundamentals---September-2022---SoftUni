using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                add();
            }
            else if (operation == "multiply")
            {
                multiply();
             }
            else if (operation == "multiply")
            {
                subtract();
            }
            else
            {
                divide();
            }

        }


        static void add()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(numberOne + numberTwo);
        }

        static void multiply()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(numberOne * numberTwo);
        }

        static void subtract()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(numberOne - numberTwo);
        }

        static void divide()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(numberOne / numberTwo);
        }
    }
}
