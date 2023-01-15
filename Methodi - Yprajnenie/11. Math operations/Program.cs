using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int result = Operation(first,@operator,second);
            Console.WriteLine(result);
        }

        static int Operation(int a,char @operator, int b)
        {
            int result = 0;
            if (@operator == '+')
            {
                 result = a + b;
            }
            
            else if (@operator == '/')
            {
                result = a / b;
            }

            else if (@operator == '*')
            {
                result = a * b;
            }
            else if (@operator == '-')
            {
                result = a - b;
            }
            return result;
        }

    }
}
