using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfLines = int.Parse(Console.ReadLine());
            const int CAPACITY = 255;
            int totalQuantity = CAPACITY;
            

            for (int i = 0; i < numOfLines; i++)
            {
                int currQuantity = int.Parse(Console.ReadLine());

                if (totalQuantity - currQuantity >= 0)
                {
                    totalQuantity -= currQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            int totalFieldQuantity = CAPACITY - totalQuantity; 
            Console.WriteLine(totalFieldQuantity);




















            //int numOfLines = int.Parse(Console.ReadLine());
            //const int CAPACITY = 255;

            //int quantitiesNow = 0;

            //for (int i = 0; i < numOfLines; i++)
            //{
            //    int totalQuantity = int.Parse(Console.ReadLine());

            //    if (quantitiesNow + totalQuantity > CAPACITY)
            //    {
            //        Console.WriteLine("Insufficient capacity!");
            //    }
            //    else
            //    {
            //        quantitiesNow += totalQuantity;
            //    }
            //}

            //Console.WriteLine(quantitiesNow);



            //int numOfLines = int.Parse(Console.ReadLine());

            //int quantitiesNow = 0;
            //int count = 0;
            //while (quantitiesNow <= 255 ) //count <= numOfLines
            //{
            //    int quantitiesOfWater = int.Parse(Console.ReadLine());
            //    count++;
            //    quantitiesNow += quantitiesOfWater;

            //    if(quantitiesNow >= 255)
            //    {
            //        quantitiesNow = quantitiesNow - quantitiesOfWater;
            //        Console.WriteLine("Insufficient capacity!");
            //        //continue;
            //    }

            //    if(count == numOfLines)
            //    {

            //        break;
            //    }



            //    // quantitiesOfWater = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(quantitiesNow);





        }
    }
}
