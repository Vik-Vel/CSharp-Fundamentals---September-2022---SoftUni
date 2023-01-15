using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numOfWagons];
            int sum = 0;

            for (int indexOfWagons = 0; indexOfWagons < wagons.Length ; indexOfWagons++)
            {
                wagons[indexOfWagons] = int.Parse(Console.ReadLine());
                sum += wagons[indexOfWagons];
            }

            foreach (var wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }




            //for (int i = 0; i < wagons.Length; i++)
            //{
            //    Console.WriteLine($"{wagons[i]}");
            //}

            Console.WriteLine();
            Console.WriteLine(sum);

            








        }
    }
}
