using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
























            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string command = Console.ReadLine();

            //while (command != "End")
            //{
            //    string[] tokens = command.Split();
            //    string nameOfComand = tokens[0];


            //    if (nameOfComand == "Add")
            //    {
            //        int number = int.Parse(tokens[1]);
            //        numbers.Add(number);
            //    }

            //    else if (nameOfComand == "Insert")
            //    {
            //        int number = int.Parse(tokens[1]);
            //        int index = int.Parse(tokens[2]);
            //        if (index <= numbers.Count && index < 0)
            //        {
            //            Console.WriteLine("Invalid index");

            //        }
            //        else
            //        {
            //            numbers.Insert(index, number);
            //        }
            //    }

            //    else if (nameOfComand == "Remove")
            //    {
            //        int index = int.Parse(tokens[1]);
            //        if (index >= numbers.Count || index < 0 )
            //        {
            //            Console.WriteLine("Invalid index");
                        
            //        }
            //        else
            //        {
            //            numbers.RemoveAt(index);

            //        }
            //    }

            //    else if (nameOfComand == "Shift")
            //    {
            //        if (tokens[1] == "left")
            //        {
            //            int count = int.Parse(tokens[2]);
            //            for (int i = 0; i < count; i++)
            //            {
            //                numbers.Add(numbers[0]);
            //                numbers.RemoveAt(0);
            //            }
            //        }

            //        if (tokens[1] == "right")
            //        {
            //            int count = int.Parse(tokens[2]);
            //            for (int i = 0; i < count; i++)
            //            {
            //                numbers.Insert(0, numbers[numbers.Count - 1]);
            //                numbers.RemoveAt(numbers.Count-1);
            //            }
            //        }
            //    }

               

            //    command = Console.ReadLine();

            //}

            //Console.WriteLine(string.Join(" ", numbers));


            //List < int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            //string command = Console.ReadLine();

            //while (command != "End")
            //{
            //    string[] token = command.Split();

            //    switch (token[0])
            //    {
            //        case "Add":
            //            int index = int.Parse(token[1]);
            //            list.Add(index);
            //            break;

            //        case "Insert":
            //            int index2 = int.Parse(token[2]);
            //            int number = int.Parse(token[1]);
            //            if (index2 <= list.Count && index2 < 0)
            //            {
            //                Console.WriteLine("Invalid index");
            //            }
            //            else
            //            {
            //                list.Insert(index2, number);
            //            }
            //            break;

            //        case "Remove":
            //            int index3 = int.Parse(token[1]);
            //            if (index3 >= list.Count || index3 < 0)
            //            {
            //                Console.WriteLine("Invalid index");

            //            }
            //            else
            //            {
            //                list.RemoveAt(index3);
            //            }
            //            break;

            //    }


            //    if (token[0] == "Shift")
            //    {
            //        int count = int.Parse(token[2]);
            //        if (token[1] == "left")
            //        {
            //            for (int i = 0; i < count; i++)
            //            {
            //                list.Add(list[0]);
            //                list.RemoveAt(0);
            //            }
            //        }
            //        else if (token[1] == "right")
            //        {
            //            for (int i = 0; i < count; i++)
            //            {
            //                list.Insert(0, list[list.Count - 1]);
            //                list.RemoveAt(list.Count - 1);
            //            }
            //        }
            //    }
            //    command = Console.ReadLine();
            //}
            //Console.WriteLine(string.Join(" ", list));
        }
    }
}
