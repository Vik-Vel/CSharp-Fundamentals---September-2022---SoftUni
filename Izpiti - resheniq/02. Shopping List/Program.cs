using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] commands = input.Split();

                string product = commands[1];
                if (commands[0] == "Urgent")
                {
                    Urgent(groceries, product);
                }

                else if (commands[0] == "Unnecessary")
                {
                    Unnecessary(groceries, product);
                }

                else if (commands[0] == "Correct")
                {
                    string newItem = commands[2];
                    Correct(groceries, product, newItem);
                }

                else if (commands[0] == "Rearrange")
                {
                    Rearrange(groceries, product);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",groceries));
        }

         static void Rearrange(List<string> groceries, string product)
        {
            if (groceries.Contains(product))
            {
                groceries.Remove(product);
                groceries.Add(product);
            }



        }

        static void Correct(List<string> groceries, string product,string newItem)
        {
            if (groceries.Contains(product))
            {
                int index = groceries.IndexOf(product);
                groceries.Insert(index, newItem);
                groceries.Remove(product);
            }


        }

        static void Unnecessary(List<string> groceriesgroceries, string product)
        {
            if (groceriesgroceries.Contains(product))
            {
                groceriesgroceries.Remove(product);
            }
        }

        static void Urgent(List<string> groceries,string product)
        {
            if (!groceries.Contains(product))
            {
                groceries.Insert(0, product);
            }


        }
    }
}
