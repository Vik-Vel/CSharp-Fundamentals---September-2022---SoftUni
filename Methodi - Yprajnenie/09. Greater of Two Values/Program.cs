using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int result = GetMax(first, second);
                    Console.WriteLine(result);
                    break;

                case "string":
                    string firstS = Console.ReadLine();
                    string secondS = Console.ReadLine();
                    string resultS = GetMax(firstS, secondS);
                    Console.WriteLine(resultS);
                    break;

                case "char":
                    char firstCh = char.Parse(Console.ReadLine());
                    char secondCh = char.Parse(Console.ReadLine());
                    char resultCh = GetMax(firstCh, secondCh);
                    Console.WriteLine(resultCh);
                    break;
            }




        }

         static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);


            if (result>0)
            {
                return first;
            }
            return second;
        }

         static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
    }
}
