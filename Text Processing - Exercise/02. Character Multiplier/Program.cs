using System;
using System.Text;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            GetStringSum(inputs[0], inputs[1]);


        }

        public static void GetStringSum(string one, string two)
        {
           int min = Math.Min(one.Length, two.Length);
            
            int sum = 0;
            for (int i = 0; i < min; i++)
            {

                for (int k = i; k <=i ; k++)
                {
                    sum += one[i] * two[k];
                }
            }

            string longest = one;
            if (longest.Length < two.Length)
            {
                longest = two;
            }

            for (int i = min; i < longest.Length; i++)
            {
                sum += longest[i];
            }


            Console.WriteLine(sum);
        }



















        //----------------------------------------------------------

        //string[] input = Console.ReadLine().Split();

        //GetStrinvSum(input[0], input[1]);

        //private static void GetStrinvSum(string stringOne, string stringTwo)
        //{
        //    int sum = 0;
        //    int minLength = Math.Min(stringOne.Length, stringTwo.Length);
        //    for (int i = 0; i < minLength; i++)
        //    {
        //        sum += stringOne[i] * stringTwo[i]; 
        //    }

        //    string longestLegthString = stringOne;

        //    if (longestLegthString.Length < stringTwo.Length)
        //    {
        //        longestLegthString = stringTwo;
        //    }

        //    for (int i = minLength; i < longestLegthString.Length; i++)
        //    {
        //        sum += longestLegthString[i];
        //    }

        //    Console.WriteLine(sum);
        //}

    }


    
}
