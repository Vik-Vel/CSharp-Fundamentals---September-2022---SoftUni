using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {


























            //--------------------------------------------

           // int numOfHeroes = int.Parse(Console.ReadLine());

           // Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

           // string input = string.Empty;

           // for (int i = 0; i < numOfHeroes; i++)
           // {
           //     input = Console.ReadLine();
           //     string[] tokens = input.Split();
           //     string nameOfHero = tokens[0];
           //     int HP = int.Parse(tokens[1]);
           //     int MP = int.Parse(tokens[2]);


           //     if (!heroes.ContainsKey(nameOfHero))
           //     {
           //         heroes.Add(nameOfHero, new List<int>());
           //     }

           //     heroes[nameOfHero].Add(HP);
           //     heroes[nameOfHero].Add(MP);
           // }

           // input = Console.ReadLine();

           ////proweri proverkite s nad 100 i 200

           // while (input != "End")
           // {
           //     string[] tokens = input.Split(" - ");

           //     string command = tokens[0];

           //     if (command == "CastSpell")
           //     {
           //         string heroName = tokens[1];
           //         int mpNeeded = int.Parse(tokens[2]);
           //         string spellName = tokens[3];

                        
           //             if (heroes[heroName][1] - mpNeeded >= 0)
           //             {
           //             heroes[heroName][1] = heroes[heroName][1] - mpNeeded;
           //                 Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
           //             }
           //             else
           //             {
           //                 Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
           //             }
                   

           //     }
           //     else if (command == "TakeDamage")
           //     {
           //         string heroName = tokens[1];
           //         int damage = int.Parse(tokens[2]);
           //         string attacker = tokens[3];

           //         if ((heroes[heroName][0] - damage) > )0
           //         {
           //             heroes[heroName][0] = heroes[heroName][0] - damage;

           //             Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
           //         }
           //         else
           //         {
           //             Console.WriteLine($"{heroName} has been killed by {attacker}!");

           //             heroes.Remove(heroName);
           //         }

           //     }
           //     else if (command == "Recharge")
           //     {
           //         string heroName = tokens[1];
           //         int amount = int.Parse(tokens[2]);
                    

           //         if (heroes[heroName][1] + amount > 200)
           //         {
           //             amount = 200 - heroes[heroName][1];
           //             heroes[heroName][1] = 200;
           //         }
           //         else
           //         {
           //             heroes[heroName][1] += amount;
           //         }

           //         Console.WriteLine($"{heroName} recharged for {amount} MP!");

                   
           //     }
           //     else if (command == "Heal")
           //     {
           //         string heroName = tokens[1];
           //         int amount = int.Parse(tokens[2]);
                   

           //         if (heroes[heroName][0] + amount > 100) 
           //         {
           //             amount = 100 - heroes[heroName][0];
           //             heroes[heroName][0] = 100;
           //         }
           //         else
           //         {
           //             heroes[heroName][0] += amount;
           //         }
           //         Console.WriteLine($"{heroName} healed for {amount} HP!");
           //     }

           //     input = Console.ReadLine();
           // }

           // foreach (var (name, value) in heroes)
           // {
           //     Console.WriteLine(name);
           //     Console.WriteLine($"  HP: {value[0]}");
           //     Console.WriteLine($"  MP: {value[1]}");


           // }

        }
    }
}
