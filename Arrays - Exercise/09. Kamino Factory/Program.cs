using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int sequenceLength = int.Parse(Console.ReadLine()); //взимаме дължината на всички елементи, които бъдат въведени
            string input = Console.ReadLine(); // четем си входа

            int[] DNA = new int[sequenceLength]; // създаваме празен масив с дължината на всички елементи от [sequenceLength]
            int dnaSum = 0; //сума от днка-та
            int dnaCount = -1;
            int dnaStrartIndex = -1; // може и 0
            int dnaSamples = 0; 

            int sample = 0;//проби

            while (input != "Clone them!") 
            {
                sample++; //увеличаваме броя на пробите
                int[] currDNA = input.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); //взимаме текущо днк-а и го сплитваме(разделяме) с оператор " ! ", след това го превръщаш в масив от цифри и го връщаш, като масив!

                //тук създаваме променливи за ТЕКУЩОТО ДНК-А
                int currCount = 0;
                int currStrartIndex = 0;
                int currEndIndex = 0;
                int currDnaSum = 0;
                bool isCurrDnaBetter = false;

                int count = 0;

                for (int i = 0; i < currDNA.Length; i++)
                {
                    if(currDNA[i] != 1) // търси колко е най-голямата последователност от 1-ци 
                    {
                        count = 0; //ако влезе вътре и има число разллично от 0 , демек 1, зануляваме брояча
                        continue;
                    }

                    count++; // увеличаваме брояча ако има 1-ци
                    if(count > currCount) //ако общия брояч е по-голям от текущия тогава :
                    {
                        currCount = count; //взимс стойността
                        currEndIndex = i; 
                    }
                }
                //00 11 0 1 => (endIndex = 2) => (startIndec 2-2 = - +1=>1)
                currStrartIndex = currEndIndex - currCount + 1; //търсим стартовия индекс, на база на крайния индекс - сегащния брояч + 1
                currDnaSum = currDNA.Sum(); //взимаме за текущото ДНК-А сумата

                //check curent dna with best dnk

                if (currCount > dnaCount) 
                {
                    isCurrDnaBetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if(currStrartIndex < dnaStrartIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currStrartIndex == dnaStrartIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            isCurrDnaBetter = true;

                        }
                    }
                }
              

                if(isCurrDnaBetter)
                {
                    DNA = currDNA;
                    dnaCount = currCount;
                    dnaStrartIndex = currStrartIndex;
                    dnaSum = currDnaSum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");

            Console.WriteLine(string.Join(" ",DNA));







        }
    }
}
