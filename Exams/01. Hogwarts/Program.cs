using System;
using System.Linq;
using System.Text;

namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            //StringBuilder word = new StringBuilder();

            //word.Append(word);
            while (input != "Abracadabra")
            {

                string[] tokens = input.Split();

                string commands = tokens[0];

                if (commands == "Abjuration")
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        char old = word[0];
                        char newW = char.ToUpper(word[0]);

                        word += newW.ToString();
                       word =  word.Remove(0, 1);
                    }
                    
                    Console.WriteLine(word);
                }
                else if (commands == "Necromancy")
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        char old = word[0];
                        char newW = char.ToLower(word[0]);

                        word += newW.ToString();
                        word = word.Remove(0, 1);
                    }
                    Console.WriteLine(word);
                }
                else if (commands == "Illusion")
                {
                    int index = int.Parse(tokens[1]);
                    string letter = tokens[2];

                    if (index >= 0 && index <= word.Length) 
                    {
                        
                       word = word.Insert(index, letter);
                       word = word.Remove(index+1, 1);

                       
                        Console.WriteLine("Done!");
                    }
                   else
                   {
                        Console.WriteLine($"The spell was too weak.");
                   }

                }
                
                else if (commands == "Divination")
                {
                    
                    string first = tokens[1];
                    string second = tokens[2];

                    int more = 0;
                    while (!word.Contains(first))
                    {
                       word= word.Replace(first, second);
                    }
                   
                    
                }
                else if(commands == "Alteration")
                {
                    string substring = tokens[1];
                    if (word.Contains(substring))
                    {
                        int index = word.IndexOf(substring);
                        word =  word.Remove(index, substring.Length);
                    }
                    Console.WriteLine(word);
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }

                
                
                input = Console.ReadLine();
            }
            
        }
    }
}
