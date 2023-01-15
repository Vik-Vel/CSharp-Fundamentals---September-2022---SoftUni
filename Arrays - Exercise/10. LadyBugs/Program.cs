using System;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int razmerNaPoleto = int.Parse(Console.ReadLine());

            int[] ladyBugsField = new int[razmerNaPoleto];

            string[] zaetiIndexi = Console.ReadLine().Split();

            for (int i = 0; i < zaetiIndexi.Length; i++)
            {
                int momentenIndex = int.Parse(zaetiIndexi[i]);

                if (momentenIndex >= 0 && momentenIndex < razmerNaPoleto)
                {
                    ladyBugsField[momentenIndex] = 1;
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                bool isFirst = true;
                int currentIndec = int.Parse(commands[0]);
                while (currentIndec >= 0 && currentIndec < razmerNaPoleto && ladyBugsField[currentIndec] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugsField[currentIndec] = 0;
                        isFirst = false;

                    }
                    string posoka = commands[1];
                    int duljinaNaPoleto = int.Parse(commands[2]);
                    if (posoka == "left")
                    {
                        currentIndec -= duljinaNaPoleto;
                        if (currentIndec >= 0 && currentIndec < razmerNaPoleto)
                        {
                            if (ladyBugsField[currentIndec] == 0)
                            {
                                ladyBugsField[currentIndec] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndec += duljinaNaPoleto;
                        if (currentIndec >= 0 && currentIndec < razmerNaPoleto)
                        {
                            if (ladyBugsField[currentIndec] == 0)
                            {
                                ladyBugsField[currentIndec] = 1;
                                break;
                            }
                        }
                    }

                }

                commands = Console.ReadLine().Split();


            }


            Console.WriteLine(String.Join(" ", ladyBugsField));







        }
    }
}
