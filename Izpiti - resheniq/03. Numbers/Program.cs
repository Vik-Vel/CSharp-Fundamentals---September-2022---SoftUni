using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numbersGreater = new List<int>();

            double averageSum = numbers.Average();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > averageSum)
                {
                    numbersGreater.Add(numbers[i]);
                }
            }

            //Console.WriteLine(String.Join(" ", numbersGreater));

            numbersGreater.Sort();
            numbersGreater.Reverse();
           
         
            if (numbersGreater.Count <= 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                var firstFive = numbersGreater.Take(5);

                Console.WriteLine(String.Join(" ",firstFive));
            }
            
        }
    }
}
