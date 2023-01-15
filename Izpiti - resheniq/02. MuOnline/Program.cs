using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;

            List <string> rooms = Console.ReadLine().Split('|').ToList();

            
            int index = 0;
            int bitcoins = 0;
            int totalBitcoins = 0;
            

            for (int i = 0; i < rooms.Count; i++)
            {
                

                string[] roomName = rooms[i].Split();
               

                if (roomName[0] == "potion")
                {
                     index = int.Parse(roomName[1]);
                    int healted = 0;

                    if (health + index > 100)
                    {
                        healted = 100 - health;
                        health = 100;

                        Console.WriteLine($"You healed for {healted} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    else if (health <= 100) 
                    {
                        health += index;

                        Console.WriteLine($"You healed for {index} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    continue;

                }

                else if (roomName[0] == "chest")
                {
                    bitcoins = int.Parse(roomName[1]);
                    Console.WriteLine($"You found {bitcoins} bitcoins.");
                    totalBitcoins += bitcoins;
                }

                else
                {
                    string nameOfMonster = roomName[0];
                    index = int.Parse(roomName[1]);

                    health -= index;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {nameOfMonster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {nameOfMonster}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;

                    }

                }



            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {totalBitcoins}");
            Console.WriteLine($"Health: {health}");



        }
    }
}
