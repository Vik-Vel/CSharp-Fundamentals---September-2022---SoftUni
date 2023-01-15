using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            //string model = Console.ReadLine();
            //float radius = float.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());

            //float volume = (float)(Math.PI * radius * radius * height);

            double maxKeg = double.MinValue;
            string maxKegName = "";

            for (int i = 1; i <= numOfKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());


                double volume = Math.PI * Math.Pow(radius,2) * height; 

                // volume = Math.PI * radius * radius * height;
                if (volume > maxKeg)
                {
                    maxKeg = volume;
                    maxKegName = model;

                }

                //model = Console.ReadLine();
                //radius = float.Parse(Console.ReadLine());
                //height = int.Parse(Console.ReadLine());

                //volume = (float)(Math.PI * radius * radius * height);

            }

            Console.WriteLine(maxKegName);



        }
    }
}
