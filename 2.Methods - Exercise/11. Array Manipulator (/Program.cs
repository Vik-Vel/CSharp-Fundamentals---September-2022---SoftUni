using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Array_Manipulator__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split();

                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);
                    Exchange(numbers,index);
                }
                else if (commands[0] == "max")
                {
                        Max(commands,numbers);
                    
                }
                else if (commands[0] == "min")
                {
                    Min(commands, numbers);

                }


                input = Console.ReadLine();
            }



        }

         static void Min(string[] commands, List<int> numbers)
        {
            if (commands[1] == "even")
            {
               int min = int.MaxValue;
                int indexOfMinEven = -222;
                int counEven = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        counEven++;
                        if (numbers[i] <= min)
                        {
                            min = numbers[i];
                            indexOfMinEven = i;

                        }
                    }
                }
                if (counEven == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexOfMinEven);
                }
            }
            if (commands[1] == "odd")
            {
               int min = int.MaxValue;
                int indexOfMinOdd = int.MaxValue;
                int counOdd = -222;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        counOdd++;
                        if (numbers[i] <= min)
                        {
                            min = numbers[i];
                            indexOfMinOdd = i;
                        }
                    }
                }
                if (counOdd == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexOfMinOdd);
                }
            }
        }

        static void Max(string[] commands,List<int> numbers)
        {
            if (commands[1] == "even")
            {
                int max = int.MinValue;
                 int indexOfMaxEven = -222;
                int counEven = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        
                        if (numbers[i] >= max)
                        {
                            counEven++;
                            max = numbers[i];
                            indexOfMaxEven = i;
                        }
                    }
                }
                if (counEven == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexOfMaxEven);
                }
            }
            if (commands[1] == "odd")
            {
                int max = int.MinValue;
                int indexOfMaxOdd = -222;
                int counOdd = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] >= max) 
                        {
                            counOdd++;
                            max = numbers[i];
                            indexOfMaxOdd = i;
                        }
                    }
                }
                if (counOdd == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexOfMaxOdd);
                }
            }

        }

        static void Exchange(int[] numbers,int index)
        {
            int[] temp = new int[index + 1];

            // Тук намираме колко символа от лявата част на масива трябва да се преместят и ги запазваме в един стринг
            for (int i = 0; i <= index; i++)// index =2
            {
                temp[i] = numbers[i]; // ['1', '2', '3']
            }

            //Тук преместваме всички числа в масива с index + 1 позиции
            for (int i = 0; i <= index; i++)
            {
                for (int k = 0; k < numbers.Length - 1; k++)
                {
                    numbers[k] = numbers[k + 1];
                }
            }

            // Тук слагаме изрязаните числа от началото на масива, които ги запазихме в стринга, да са в края му
            int counter3 = 0;

            for (int i = numbers.Length - 1 - index; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(temp[counter3].ToString());
                counter3++;
            }
        }
    }
}
