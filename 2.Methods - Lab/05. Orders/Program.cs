using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.00;

            if (product == "coffee")
            {
                Price(coffee, quantity);
            }
            else if (product == "water")
            {
                Price(water, quantity);
            }
            else if (product == "coke")
            {
                Price(coke, quantity);
            }
            else if (product == "snacks")
            {
                Price(snacks, quantity);
            }

        }

         static void Price(double quantity,double product)
        {
            Console.WriteLine($"{product * quantity:f2}");
        }
    }
}
