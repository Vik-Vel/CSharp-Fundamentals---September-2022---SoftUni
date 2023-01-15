using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double coffee = 1.50;
            double water = 1;
            double coke = 1.40;
            double snacks = 2;

            if (order == "coffee")
            {
                double total = Salary(coffee, quantity);
                Console.WriteLine($"{total:f2}");
            }

            else if (order == "water")
            {
                double total = Salary(water, quantity);
                Console.WriteLine($"{total:f2}");
            }

            else if (order == "coke")
            {
                double total = Salary(coke, quantity);
                Console.WriteLine($"{total:f2}");
            }

            else if (order == "snacks")
            {
                double total = Salary(snacks, quantity);
                Console.WriteLine($"{total:f2}");
            }

        }

        static double Salary(double order, int quantity)
        {

            return order * quantity;
        }
    }
}
