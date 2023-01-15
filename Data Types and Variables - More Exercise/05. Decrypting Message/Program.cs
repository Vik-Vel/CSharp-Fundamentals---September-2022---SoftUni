using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numOfIntervals = int.Parse(Console.ReadLine());

            string message = "";
            while(numOfIntervals > 0)
            {
                for (int i = 0; i < numOfIntervals; i++)
                {
                    message+= ((char)(char.Parse(Console.ReadLine()) + key)).ToString();

                    numOfIntervals--;
                }
                

            }
            Console.WriteLine(message);




        }
    }
}
