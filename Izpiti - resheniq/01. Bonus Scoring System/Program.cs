using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOfStudents = double.Parse(Console.ReadLine());
            double numOfLectures = double.Parse(Console.ReadLine());
            double bonufForCurse = double.Parse(Console.ReadLine());

            double count = 0;
            double totalBonus = 0;
            double maxBonus = int.MinValue;
            double currLectures = 0;

            if (numOfStudents == 0 || numOfLectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            } 

            for (int i = 0; i < numOfStudents; i++)
            {
                count = int.Parse(Console.ReadLine());

                 totalBonus = count / numOfLectures * (5 + bonufForCurse);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    currLectures = count;
                }


            }
            Console.WriteLine($"Max Bonus: {Math.Round (maxBonus)}.");
            Console.WriteLine($"The student has attended {currLectures} lectures.");


        }
    }
}
