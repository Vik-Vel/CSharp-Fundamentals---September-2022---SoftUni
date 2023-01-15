using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                string nameOfComand = tokens[0];

                if (nameOfComand == "swap")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    Swap(numbers, index1, index2);
                }

                else if (nameOfComand == "multiply")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    Multiply(numbers, index1, index2);
                }

                else if (nameOfComand == "decrease")
                {
                    Decrease(numbers);
                }



                command = Console.ReadLine();
            }


            Console.WriteLine(string.Join(", ",numbers));
        }

         static void Decrease(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= 1;
            }

        }

        static void Multiply(List<int> numbers, int index1, int index2)
        {
            numbers.Insert(index1, numbers[index1] * numbers[index2]);
            numbers.RemoveAt(index1+1);


        }

        static void Swap(List<int> numbers, int index1, int index2)
        {
            int copy1 = numbers[index1];
            int copy2 = numbers[index2];
            numbers.Insert(index1, numbers[index2]);
            numbers.RemoveAt(index1 + 1);
            numbers.Insert(index2, copy1);
            numbers.RemoveAt(index2 + 1);


        }
    }
}
