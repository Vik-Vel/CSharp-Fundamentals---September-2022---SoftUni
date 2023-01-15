using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string username = Console.ReadLine();
            string pass = Console.ReadLine();
            int counter = 0;

            string password = string.Empty; //""


            for (int reverseIndex = username.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                password += username[reverseIndex];
            }


            for (int i = 1; i < 4; i++)
            {
                
                if (password != pass)
                {
                    counter++;
                    Console.WriteLine("Incorrect password. Try again.");
                    pass = Console.ReadLine();
                }
               
            }
            if (counter == 3)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else if (counter < 4 && pass == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }




        }
    }
}
