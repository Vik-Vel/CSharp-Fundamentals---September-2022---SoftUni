using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int allSum = 0;
            int count = 0;
            for (int i = 1; i <= 100; i++) 
            {
                if(i % 2 != 0)
                {
                    count++;
                    allSum += i;
                    Console.WriteLine(i);
                }
                if(count >= input)
                {
                    Console.WriteLine($"Sum: {allSum}");
                    break;
                }
                
            }
            

























          //int input = int.Parse(Console.ReadLine());
          //  int counterNumOfOdd = 1;
          //  int sumOfAllOdd = 0; 

          //  for (int i = 1; counterNumOfOdd <= input; i++)
          //  {
          //      if (i % 2 != 0)
          //      {
          //          Console.WriteLine(i);
                   
          //          counterNumOfOdd++;
          //          sumOfAllOdd = sumOfAllOdd + i;

          //      }
               
          //  }
          // Console.WriteLine($"Sum:{sumOfAllOdd}");

           
        }
    }
}
