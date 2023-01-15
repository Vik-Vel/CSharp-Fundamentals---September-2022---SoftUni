using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double one = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double two = double.Parse(Console.ReadLine());
            double result = Calculate(one, @operator, two);
            Console.WriteLine(result);

        }

        static  double Calculate(double one, string @operator, double two)
        {
            double result = 0;
            result = Math.Abs(result);
            switch (@operator)
            {
                case  "*":
                    result = one * two;
                    break;

                    case "+":
                    result = one + two;
                    break;

                case "-":
                    result = one - two;
                    break;

                case "/":
                    result = one / two;
                    break;
            }
            return result;
        }
    }
}
