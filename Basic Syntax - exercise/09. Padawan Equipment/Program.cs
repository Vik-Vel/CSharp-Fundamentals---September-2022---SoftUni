using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double counter = 0;
            double totalAmount = 0;

            double costLightsaber = priceOfLightsaber * Math.Ceiling(countOfStudents * 1.1);
            double costRobe = priceOfRobes * countOfStudents;
            double costBelts = priceOfBelts *(countOfStudents - Math.Floor( countOfStudents/6));
           // countOfStudents = countOfStudents * 1.10;

           
           
           

            totalAmount = costBelts + costLightsaber + costRobe ;

            
            if(totalAmount <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalAmount:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalAmount-amountOfMoney:f2}lv more.");
            }    




        }
    }
}
