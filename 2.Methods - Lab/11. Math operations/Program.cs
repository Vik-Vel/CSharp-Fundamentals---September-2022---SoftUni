using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            double result = Calculate(num, @operator, num2);
            Console.WriteLine(result);


        }

         static double Calculate(int num, string @operator, int num2)
        {
            double result = 0;
            if (@operator == "/")
            {
                result = num / num2;
            }
            else if(@operator == "*")
            {
                result = num * num2;
            }
            else if (@operator == "+")
            {
                result = num + num2;
            }
            else if (@operator == "-")
            {
                result = num - num2;
            }
            return result;
        }
    }
}
