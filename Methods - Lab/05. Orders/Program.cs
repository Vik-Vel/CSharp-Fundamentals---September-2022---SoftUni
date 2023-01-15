using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
       


            QuanityOfProduct();

            //$"{sumOfProducts:f2}"

        }


        static void QuanityOfProduct()
        {
            string product = Console.ReadLine();
            int numOfProduct = int.Parse(Console.ReadLine());
            double sumOfProducts = 0;
            if (product == "coffee")
            {
                sumOfProducts = numOfProduct * 1.50;
            }

            else if (product == "water")
            {
                sumOfProducts = numOfProduct * 1;
            }

            else if (product == "coke")
            {
                sumOfProducts = numOfProduct * 1.40;
            }

            else if (product == "snacks")
            {
                sumOfProducts = numOfProduct * 2.00;
            }
            Console.WriteLine($"{sumOfProducts:f2}");
        }
    }
}
