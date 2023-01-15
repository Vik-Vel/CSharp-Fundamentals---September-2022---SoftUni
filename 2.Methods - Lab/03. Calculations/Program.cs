using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //int number = int.Parse(Console.ReadLine());
            //int numberTwo = int.Parse(Console.ReadLine());


            if (input == "add")
            {
                Add();
            }
            else if (input == "multiply")
            {
                Multiply();
            }
            else if (input == "subtract")
            {
                Substract();
            }
            else if (input == "divide")
            {
                Divide();
            }
        }

         static void Add()
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int result = number + numberTwo;
            Console.WriteLine(result);

        }
        static void Multiply()
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int result = number * numberTwo;
            Console.WriteLine(result);
        }

        static void Substract()
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int result = number - numberTwo;
            Console.WriteLine(result);
        }

        static void Divide()
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int result = number / numberTwo;
            Console.WriteLine(result);
        }
    }
}
