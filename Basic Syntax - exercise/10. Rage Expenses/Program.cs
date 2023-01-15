using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());


            double countLostGame = 0;
            double countKeyboarsTrashed = 0;
            double allCost = 0;

            for (int i = 1; i <= lostGame; i++)
            {
                countLostGame++;

                if (countLostGame % 2 == 0 )
                {
                    allCost = allCost + priceHeadset;
                }
                 if (countLostGame % 3 == 0 )
                {
                    allCost = allCost + priceMouse;
                }
                 if (countLostGame % 2 == 0 && countLostGame % 3 == 0)
                {
                    allCost = allCost + priceKeyboard;
                    countKeyboarsTrashed++;
                    if (countKeyboarsTrashed % 2 == 0)
                    {
                        allCost = allCost + priceDisplay;
                    }
                }

            }

            Console.WriteLine($"Rage expenses: {allCost:f2} lv.");

        }
    }
}
