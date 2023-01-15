using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
























            //-----------------------------------

            //Dictionary <string, List<int>> cars = new Dictionary<string, List<int>>();

            //int n = int.Parse(Console.ReadLine());

            //string input;
            //for (int i = 0; i < n; i++)
            //{
            //    input = Console.ReadLine();

            //    string[] tokens = input.Split('|');

            //    string nameOfTheCar = tokens[0];
            //    int mileage = int.Parse(tokens[1]);
            //    int fuel = int.Parse(tokens[2]);

            //    if (!cars.ContainsKey(nameOfTheCar))
            //    {
            //        cars.Add(nameOfTheCar, new List<int>());
            //    }

            //    cars[nameOfTheCar].Add(mileage);
            //    cars[nameOfTheCar].Add(fuel);


            //}

            //input = Console.ReadLine();

            //while (input != "Stop")
            //{
                

            //    string[] tokens = input.Split(" : ");

            //    string command = tokens[0];
            //    string car = tokens[1];

            //    if (command == "Drive")
            //    {
            //        int distance = int.Parse(tokens[2]);
            //        int fuel = (int.Parse(tokens[3]));

            //        if (cars[car][1] < fuel)
            //        {
            //            Console.WriteLine("Not enough fuel to make that ride");
            //        }
            //        else
            //        {
            //            cars[car][1] -= fuel;
            //            cars[car][0] += distance;

            //            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            //        }

            //        if (cars[car][0] >= 100000)
            //        {
            //            Console.WriteLine($"Time to sell the {car}!");
            //            cars.Remove(car);
            //        }
            //    }

            //    else if (command == "Refuel")
            //    {
            //        int fuel = int.Parse(tokens[2]);

            //        if (cars[car][1] + fuel >= 75)
            //        {
                        
            //            fuel = 75 - cars[car][1];
            //            cars[car][1] = 75;
                        
            //        }
            //        else
            //        {
            //            cars[car][1] += fuel;
            //        }
            //        Console.WriteLine($"{car} refueled with {fuel} liters");

            //    }

            //    else if (command == "Revert")
            //    {
            //        int kilometers = int.Parse(tokens[2]);
                    
            //        if (cars[car][0] - kilometers <= 10000)
            //        {
            //            cars[car][0] = 10000;
            //        }
            //        else
            //        {
            //            cars[car][0] -= kilometers;

            //            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
            //        }
            //    }

            //    input = Console.ReadLine();
            //}

            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            //}
        }
    }
}
