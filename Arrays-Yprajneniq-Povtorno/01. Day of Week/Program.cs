using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfWeek = int.Parse(Console.ReadLine());
            
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (numOfWeek >= 1 && numOfWeek <= 7) 
            {
                Console.WriteLine(days[numOfWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }


        }
    }
}
