using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers =  Console.ReadLine().Split().Select(int.Parse).ToList();
            //int index = int.Parse(Console.ReadLine());
            int index;
            int currNum;
            int sum = 0;

            while (numbers.Count != 0)
            {
                index = int.Parse(Console.ReadLine());


                if (index < 0)
                {
                    currNum = numbers[0];
                    sum += currNum;
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (index > numbers.Count - 1)
                {
                    currNum = numbers[numbers.Count - 1];
                    sum += currNum;
                 
                    numbers[numbers.Count - 1] = numbers[0];
                   
                }
                else
                {
                    currNum = numbers[index];
                    sum += currNum;

                    numbers.RemoveAt(index);

                }


                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= currNum )
                    {
                        numbers[i] += currNum;
                    }
                    else 
                    {
                        numbers[i] -= currNum;
                    }

                    

                }

                
            }

            
            Console.WriteLine(sum);

        }
    }
}
