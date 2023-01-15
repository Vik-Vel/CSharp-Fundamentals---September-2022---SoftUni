using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double priceForCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            double price = 0;
            double totalprice = 0;
            int counter = 0;

            while (counter < num)
            {
                counter++;
                price = ((days * capsulesCount) * priceForCapsule);
                    totalprice = totalprice + price;


                    Console.WriteLine($"The price for the coffee is: ${price:f2}");
               
                if(counter >= num)
                {
                    break;
                }


                
                priceForCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine($"Total: ${totalprice:f2}");


        }
    }
}
