using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"%([A-Z][a-z]+)%";
            string productPattern = @"<(\w+)>";
            string countPattern = @"\|([0-9]+)\|";
            string pricePattern = @"([0-9]+\.*[0-9]*)\$"; //\d\.\d\$

            double totalIncome = 0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                Match customerName = Regex.Match(input, namePattern);

                if (!customerName.Success)
                {
                    goto here;
                }

                Match productName = Regex.Match(input, productPattern);
                if (!productName.Success)
                {
                    goto here;
                }
                Match productCount = Regex.Match(input, countPattern);
                if (!productCount.Success)
                {
                    goto here;
                }
                Match productPrice = Regex.Match(input, pricePattern);

                if (!productPrice.Success)
                {
                    goto here;
                }

                var amount = int.Parse(productCount.Groups[1].Value);
                var pric = double.Parse(productPrice.Groups[1].Value);

                double sum = amount * pric;

                Console.WriteLine($"{customerName.Groups[1].Value}: {productName.Groups[1].Value} - {sum:f2}");

                totalIncome += sum;

                here:
                input = Console.ReadLine();
            }
                Console.WriteLine($"Total income: {totalIncome:f2}");


            
        }
    }
}
