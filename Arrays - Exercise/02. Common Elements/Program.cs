using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(' ');
            string[] arrTwo = Console.ReadLine().Split(' ');


            foreach (string currElement in arrOne)
            {
                for (int  i = 0;  i < arrTwo.Length;  i++)
                {
                    string secondCurElement = arrTwo[i]; //създаваме променлива стринг, която да бъде равна на всеки следващ елемент от масив две.След това сравняваме сегащния елемент от масив 1 с сегашни елемент от масив две, след това сегашния елемент от 1 с елемент две на 2ри масив и така до карая.След това взимаме 2 елемент от масив 1 и сравняваме с всички от масив 2 и така до края.

                    if (currElement == secondCurElement)
                    {
                        Console.Write($"{currElement} ");//ако има съвпадение принтираме на конзолата с разстояние
                        break;
                    }
                }
            }







        }
    }
}
