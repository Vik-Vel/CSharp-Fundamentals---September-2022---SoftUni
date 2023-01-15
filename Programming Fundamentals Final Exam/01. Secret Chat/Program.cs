using System;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {























            //--------------------------------------

            //StringBuilder word = new StringBuilder(Console.ReadLine());

            //string input;

            //while ((input = Console.ReadLine()) != "Reveal")
            //{
            //    string[] tokens = input.Split(":|:");

            //    string command = tokens[0];

            //    if (command == "InsertSpace")
            //    {
            //        int index = int.Parse(tokens[1]);

            //        word.Insert(index,' ');
            //        Console.WriteLine(word);

            //    }
            //    else if (command == "Reverse")
            //    {
            //        string subs = tokens[1];

            //        string currWord = word.ToString();

            //        int index = currWord.IndexOf(subs);

            //        if (currWord.Contains(subs))
            //        {
            //            currWord = currWord.Remove(index, subs.Length);
            //            string newSub = "";
            //            for (int i = subs.Length - 1; i >= 0; i--)
            //            {
            //                newSub += subs[i];
            //            }


            //            currWord += newSub;

            //            word.Clear();
            //            word.Append(currWord);
            //            Console.WriteLine(word);
            //        }
            //        else
            //        {
            //            Console.WriteLine("error");
            //        }
            //    }
            //    else if(command == "ChangeAll")
            //    {
            //        string subs = tokens[1];
            //        string repl = tokens[2];

            //        word.Replace(subs, repl);
            //        Console.WriteLine(word);
            //    }
            //}

            //Console.WriteLine($"You have a new text message: {word}");





            //---------------------------------------------

            //string word = Console.ReadLine();
            //string input = Console.ReadLine();

            //StringBuilder sb = new StringBuilder(); 
            //while (input != "Reveal") 
            //{
            //    string[] tokens = input.Split(":|:");

            //    string command = tokens[0];

            //    if (command == "InsertSpace")
            //    {
            //        int index = int.Parse(tokens[1]);

            //        word = word.Insert(index, " ");
            //        Console.WriteLine(word);

            //    }
            //    else if (command == "Reverse")
            //    {
            //        string substring = tokens[1];
            //        int countReplace = 0;
            //        if (countReplace == 0)
            //        {
            //            if (word.Contains(substring))
            //            {
            //                int index = word.IndexOf(substring);
            //                word = word.Remove(index, substring.Length);


            //                for (int i = substring.Length - 1; i >= 0; i--)
            //                {
            //                    sb.Append(substring[i]);
            //                }

            //                word = word.Insert(word.Length, sb.ToString());
            //                sb.Clear();
            //                countReplace++;
            //                Console.WriteLine(word);

            //            }
            //            else
            //            {
            //                Console.WriteLine("error");
            //            }
            //        }
                    
            //    }
            //    else if (command == "ChangeAll")
            //    {
            //        string substring = tokens[1];
            //        string replacement = tokens[2];

            //        while (word.Contains(substring))
            //        {
            //            word = word.Replace(substring, replacement);
            //        }
            //        Console.WriteLine(word);

            //    }

            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"You have a new text message: {word}");
        }
    }
}
