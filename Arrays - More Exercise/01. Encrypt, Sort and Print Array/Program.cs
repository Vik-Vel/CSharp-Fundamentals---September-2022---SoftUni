using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfNames = int.Parse(Console.ReadLine());
            //string names = Console.ReadLine();
          
            int[] name = new int[numOfNames];
            string vowels = "EeUuIiOoAa";
            int sumOfVowel = 0;
            int sumOfConsonant = 0;
            int totall  = 0;


            for (int i = 0; i < numOfNames; i++)
            {
                string names = Console.ReadLine();

                for (int j = 0; j < names.Length; j++)
                {
                    char currentLetter = names[j];

                    if (vowels.Contains(currentLetter))
                    {
                        char letter = (char)names[j];
                        sumOfVowel += letter  * names.Length;
                    }
                    else
                    {
                        char letter = (char)names[j];
                        sumOfConsonant += letter / names.Length;
                    }
                           
                }
                totall = sumOfVowel + sumOfConsonant;

                name[i] = totall;
                sumOfVowel = 0;
                sumOfConsonant = 0;
                totall = 0;
            }

            Array.Sort(name);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }











        }
    }
}
