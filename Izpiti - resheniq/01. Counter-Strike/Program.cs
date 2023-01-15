using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int energy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int counter = 0;
            while (command != "End of battle" ) 
            {
                counter++;
                int distance = int.Parse(command);
                

                if (energy - distance >= 0) 
                {
                    energy -= distance;

                }
                else
                {
                   counter--;
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");
                    return;
                }


                if (counter % 3 == 0)
                {
                    energy += counter; 
                }

               
                command = Console.ReadLine();
              
            }

            Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");

        }
    }
}
