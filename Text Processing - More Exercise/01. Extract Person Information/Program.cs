using System;
using System.Collections.Generic;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
           Dictionary<string, int> persons = new Dictionary<string, int>();

            for (int i = 0; i < numOfRows; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                string[] firstArr = inputs[0].Split();
                string[] secondArr = inputs[1].Split('|');

                for (int k = 0; k <firstArr.Length; k++)
                {
                    if (firstArr[k].Contains('@'))
                    {
                        persons.Add(firstArr[k], 0);
                    }
                }

                for (int p = 0; p < secondArr.Length; p++)
                {
                    if (firstArr[p].Contains('#'))
                    {
                        persons.Add(, 0);
                    }
                }
            }





        }
    }
}
