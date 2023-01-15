using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfVagons = int.Parse(Console.ReadLine());
            int[] peopleInVagons = new int[numberOfVagons];

            int allPeople = 0;
            for (int i = 0; i < numberOfVagons; i++)
            {
                peopleInVagons[i] = int.Parse(Console.ReadLine());
                allPeople += peopleInVagons[i];
                
            }
            Console.Write(String.Join(' ', peopleInVagons));
            Console.WriteLine();
            Console.WriteLine(allPeople);


        }
    }
}
