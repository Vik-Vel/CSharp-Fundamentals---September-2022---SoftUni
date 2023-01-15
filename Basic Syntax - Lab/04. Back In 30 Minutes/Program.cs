using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if(minutes >= 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours >= 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{Math.Abs(minutes):d2}");
















           //int hours = int.Parse(Console.ReadLine());
           // int minutes = int.Parse(Console.ReadLine());

           // minutes = minutes + 30;

           // if(hours >= 23)
           // {
           //     hours = 0;
           //     minutes = minutes - 60;
           //     //hours++;
           // }

           // if(minutes >= 59)
           // {
           //     minutes = minutes - 60;
           //     hours++;
           // }

           // Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}
