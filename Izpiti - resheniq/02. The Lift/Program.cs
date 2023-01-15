using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeopleWhoWait = int.Parse(Console.ReadLine());
            
            List <int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxPeoplePerWagon = 4;

            for (int i = 0; i <lift.Count; i++)
            {
                for (int j = lift[i]; j < maxPeoplePerWagon; j++)
                {
                    lift[i]++;
                    numOfPeopleWhoWait--;

                    if (numOfPeopleWhoWait == 0)
                    {
                        if (lift.Sum() < lift.Count * maxPeoplePerWagon)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(' ', lift));

                        return;
                    }
                }
            }

            Console.WriteLine($"There isn't enough space! {numOfPeopleWhoWait} people in a queue!");
            Console.WriteLine(string.Join(' ', lift));

            //for (int i = 0; i < liftsCages.Count; i++)
            //{
            //    if (liftsCages[i] < 4) 
            //    {
            //        int freeSpoots = 4 - liftsCages[i];

            //        if (numOfPeopleWhoWait >= 4 - liftsCages[i])
            //        {
            //            numOfPeopleWhoWait -= 4 - liftsCages[i];
            //            liftsCages[i] = 4;
            //        }


            //        else
            //        {
            //            liftsCages[i] += numOfPeopleWhoWait;
            //            numOfPeopleWhoWait = 0;
            //        }
            //    }

            //}
            //bool isNotFull = false;
            //for (int i = 0; i < liftsCages.Count; i++)
            //{
            //    if (liftsCages[i] <4)
            //    {
            //        isNotFull = true;
            //        break;
            //    }
            //}
            //if (numOfPeopleWhoWait == 0 && isNotFull)
            //{
            //    Console.WriteLine("The lift has empty spots!");

            //}
            //else if (numOfPeopleWhoWait > 0 && !isNotFull) 
            //{
            //    Console.WriteLine($"There isn't enough space! {numOfPeopleWhoWait} people in a queue!");
            //}

            //Console.WriteLine(String.Join(" ", liftsCages));

        }
    }
}
