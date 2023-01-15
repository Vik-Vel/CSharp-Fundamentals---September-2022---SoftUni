using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStud = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;


            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }

            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }

            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            if(type == "Students" && numStud >= 30)
            {
                totalPrice = (numStud * price) * 0.85;
            }
            else if(type == "Business" && numStud >= 100)
            {
                totalPrice = (numStud - 10) * price;
            }
            else if (type == "Regular" && numStud >= 10 && numStud <=20)
            {
                totalPrice = (numStud * price) * 0.95;
            }
            else
            {
                totalPrice = numStud * price;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");














            //switch (type)
            //{
            //    case "Students":
            //        if(day == "Friday")
            //        {
            //            totalPrice = numStud * 8.45;

            //        }

            //        else if (day == "Saturday")
            //        {
            //            totalPrice = numStud * 9.80;
            //        }

            //        else if(day == "Sunday")
            //        {
            //            totalPrice = numStud * 10.46;
            //        }
            //        break;

            //    case "Business":
            //        if (day == "Friday")
            //        {
            //            totalPrice = numStud * 10.90;
            //        }

            //        else if (day == "Saturday")
            //        {
            //            totalPrice = numStud * 15.60;
            //        }

            //        else if (day == "Sunday")
            //        {
            //            totalPrice = numStud * 16;
            //        }
            //        break;

            //    case "Regular":
            //        if (day == "Friday")
            //        {
            //            totalPrice = numStud * 15;
            //        }

            //        else if (day == "Saturday")
            //        {
            //            totalPrice = numStud *  = 20;
            //        }

            //        else if (day == "Sunday")
            //        {
            //            totalPrice = numStud *  = 22.50;
            //        }
            //        break;
            //}



            //if (type == "Students" && numStud >= 30)
            //{
            //    totalPrice = totalPrice * 0.85;
            //}
            //else if (type == "Business" && numStud >= 100)
            //{
            //    numStud = numStud - 10;
            //   totalPrice = numStud 
            //}
            //else if(numStud >= 10 && numStud <=20)
            //{
            //    totalPrice = totalPrice * 0.95;
            //}

            //Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
