using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            string input = "";
            int counter = 0;
            int countOfOpenChar = 0;
            int counterOfCloseChar = 0;

            while(numOfLines >= 0)
            {
                input = Console.ReadLine();
               



                if(input == "(")
                {
                    countOfOpenChar++;
                        counter++;
                }
                if(input == ")")
                {
                    counterOfCloseChar++;
                        counter--;
                }
                if (counter >= 2 || counter < 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

                numOfLines--;
            }
            
            if(countOfOpenChar == counterOfCloseChar)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }








        }
    }
}
