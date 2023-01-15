using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double moneyHave = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double spendMoney = 0;

            while (input != "Game Time")
            {
               


                if (input == "OutFall 4")
                {
                    if( moneyHave < 39.99 )
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    else if (moneyHave >= 39.99)
                    {
                        moneyHave -= 39.99;
                        spendMoney += 39.99;
                        Console.WriteLine($"Bought {input}");
                    }

                }

                else if (input == "CS: OG")
                {
                    if (moneyHave < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    else if (moneyHave >= 15.99)
                    {
                        moneyHave -= 15.99;
                        spendMoney += 15.99;
                        Console.WriteLine($"Bought {input}");
                    }

                }

                else if (input == "Zplinter Zell")
                {
                     if (moneyHave < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    else if (moneyHave >= 19.99)
                    {
                        moneyHave -= 19.99;
                        spendMoney += 19.99;
                        Console.WriteLine($"Bought {input}");
                    }

                }

                else if (input == "Honored 2")
                {
                    if (moneyHave < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    else if (moneyHave >= 59.99)
                    {
                        moneyHave -= 59.99;
                        spendMoney += 59.99;
                        Console.WriteLine($"Bought {input}");
                    }

                }

                else if (input == "RoverWatch")
                {
                    if (moneyHave < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    else if (moneyHave >= 29.99)
                    {
                        moneyHave -= 29.99;
                        spendMoney += 29.99;
                        Console.WriteLine($"Bought {input}");
                    }

                }

                else if (input == "RoverWatch Origins Edition")
                {
                    if (moneyHave < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    else if (moneyHave >= 39.99)
                    {
                        moneyHave -= 39.99;
                        spendMoney += 39.99;
                        Console.WriteLine($"Bought {input}");
                    }

                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (moneyHave == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                } 
                input = Console.ReadLine();
            }

            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${moneyHave:f2}");
            }




        }
    }
}
