using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> targets = Console.ReadLine ().Split ().Select(int.Parse).ToList();

            List <int> shooted = new List<int>();
            string command = Console.ReadLine();


            bool isShoted = false;

            int counter = 0;
            while (command != "End")
            {
                int index = int.Parse (command);
                int realIndex = 0;
                if (index >= 0 && index < targets.Count)
                {
                     realIndex = targets[index];
                    targets[index] -= targets[index];
                    targets[index] -= 1;
                    shooted.Add (index);

                    if (targets[index] < 0)
                    {
                        counter++;
                    }
                }
                
                else
                {
                    goto Found;
                }
                
                for (int i = 0; i < targets.Count; i++)
                {
                    int decreasingNumber = realIndex;
                    if (targets[i] > realIndex && !shooted.Contains(i))
                    {
                        targets[i] = targets[i] - decreasingNumber;
                    }
                    else if (targets[i] <= realIndex && !shooted.Contains(i))
                    {
                        targets[i] = targets[i] + decreasingNumber; ;
                    }
                    else
                    {
                        continue;
                    }

                    
                }

                Found:
                command = Console.ReadLine();


            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");


        }
    }
}
