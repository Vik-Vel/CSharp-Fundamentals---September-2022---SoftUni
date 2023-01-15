using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double total = 0;
            while (true)
            {
                if (input == "special" || input == "regular")
                {
                    break;
                }
                double partsPrice = double.Parse(input);
                if (partsPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    total += partsPrice;

                    
                }
                input = Console.ReadLine();
            }
            double taxes = total * 0.2;
            double finalPrice = total + taxes;

            if (finalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (input == "special")
            {
                // finalPrice = finalPrice - (finalPrice * 0.1);
                //finalPrice = finalPrice * 0.9;
                finalPrice -= finalPrice * 0.1;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:F2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:F2}$");
            }

        }
    }
}
