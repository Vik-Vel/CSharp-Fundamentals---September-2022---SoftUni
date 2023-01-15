using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameOfTheDamon = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> damonsNames = new List<string>();

            Regex healthRegex = new Regex(@"[^+\-*/.\d]");

            Regex dmgRegex = new Regex(@"((|-)\d+\.\d+|(|-)\d+)");

            var demonData = new Dictionary<string, KeyValuePair<int, double>>(nameOfTheDamon.Length - 1);



            foreach (var demon in nameOfTheDamon.OrderBy(x => x))
            {
                int health = 0;

                var sumChar = healthRegex.Matches(demon).ToArray();

                foreach (var ch in sumChar)
                {
                    health += char.Parse(ch.Value);
                }


                double damage = 0;

                var dmg = dmgRegex.Matches(demon).ToArray();

                foreach (var number in dmg)
                {
                    damage += double.Parse(number.Value);
                }

                var mathSymbols = Regex.Matches(demon, @"[\*\/]").ToArray();

                foreach (var symbol in mathSymbols)
                {
                    var mathOperation = symbol.Value == "*";
                }

            }
            
               





        }

         static void Health()
        {
            

            
        }
    }
}
