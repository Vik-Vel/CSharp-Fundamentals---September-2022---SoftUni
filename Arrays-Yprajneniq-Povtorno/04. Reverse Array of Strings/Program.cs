using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] arr = Console.ReadLine().Split();
            string [] arr2 = new string [arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = new string (arr[i]);
            }

           Array.Reverse (arr2);
            Console.WriteLine(string.Join(' ',arr2));


        }
    }
}
