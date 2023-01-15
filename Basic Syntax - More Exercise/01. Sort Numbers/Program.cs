using System;
using System.Linq;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int numOne = int.Parse(Console.ReadLine());
			int numTwo = int.Parse(Console.ReadLine());
			int numThree = int.Parse(Console.ReadLine());


			if(numOne >= numTwo && numOne >= numThree)
            {
                Console.WriteLine(numOne);
				if(numTwo >= numThree)
                {
                    Console.WriteLine(numTwo);
                    Console.WriteLine(numThree);
                }
				else
                {
					Console.WriteLine(numThree);
					Console.WriteLine(numTwo);
				}
            }
			else if (numTwo >= numOne && numTwo >= numThree)
			{
				Console.WriteLine(numTwo);
				if (numOne >= numThree)
				{
					Console.WriteLine(numOne);
					Console.WriteLine(numThree);
				}
				else
                {
					Console.WriteLine(numThree);
					Console.WriteLine(numOne);
				}
			}
			else if (numThree >= numOne && numThree >= numTwo)
			{
				Console.WriteLine(numThree);
				if (numTwo >= numOne)
				{
					Console.WriteLine(numTwo);
					Console.WriteLine(numOne);
				}
				else
                {
					Console.WriteLine(numOne);
					Console.WriteLine(numTwo);
				}
			}















			//int[] myNumbers = { numOne, numTwo, numThree };
			//Console.WriteLine(myNumbers.Max());
			//Console.WriteLine(myNumbers.Min());



			//int number = int.Parse(Console.ReadLine());
			//int number2 = int.Parse(Console.ReadLine());
			//int number3 = int.Parse(Console.ReadLine());

			//if (number >= number2 && number >= number3)
			//{
			//	Console.WriteLine(number);
			//	if (number2 >= number3)
			//	{
			//		Console.WriteLine(number2);
			//		Console.WriteLine(number3);
			//	}
			//	else
			//	{
			//		Console.WriteLine(number3);
			//		Console.WriteLine(number2);
			//	}
			//}
			//if (number2 >= number3 && number2 >= number)
			//{
			//	Console.WriteLine(number2);
			//	if (number > number3)
			//	{
			//		Console.WriteLine(number);
			//		Console.WriteLine(number3);
			//	}
			//	else
			//	{
			//		Console.WriteLine(number3);
			//		Console.WriteLine(number);
			//	}
			//}
			//if (number3 >= number2 && number3 >= number)
			//{
			//	Console.WriteLine(number3);
			//	if (number >= number2)
			//	{
			//		Console.WriteLine(number);
			//		Console.WriteLine(number2);
			//	}
			//	else
			//	{
			//		Console.WriteLine(number2);
			//		Console.WriteLine(number);
			//	}
			//}
		}
	}
}
