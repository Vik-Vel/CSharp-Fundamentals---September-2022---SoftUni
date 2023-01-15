using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {























            //----------------------------------

            //string encryptedMessage = Console.ReadLine();

            //string input = Console.ReadLine();

            //while (input != "Decode")
            //{
            //    string[] tokens = input.Split('|');

            //    string command = tokens[0];

            //    if (command == "Move")
            //    {
            //        int numOfLetters = int.Parse(tokens[1]);

            //        string sub = encryptedMessage.Substring(0, numOfLetters);

            //       encryptedMessage = encryptedMessage.Remove(0, numOfLetters);
            //      encryptedMessage =  encryptedMessage.Insert(encryptedMessage.Length, sub);


            //    }
            //    else if (command == "Insert")
            //    {
            //        int index = int.Parse(tokens[1]);
            //        string value = tokens[2];

            //        if (index >= 0 && index <= encryptedMessage.Length)
            //        {
            //            encryptedMessage = encryptedMessage.Insert(index, value);
            //        }
                   

            //    }
            //    else if (command == "ChangeAll")
            //    {
            //        string substring = tokens[1];
            //        string replacement = tokens[2];

            //        encryptedMessage = encryptedMessage.Replace(substring, replacement);
            //    }
                

            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"The decrypted message is: {encryptedMessage}");




            //------------------------------------------

            //StringBuilder sb = new StringBuilder();

            //string word = Console.ReadLine();
            //string input = Console.ReadLine();
            //sb.Append(word);
            //while (input != "Decode")
            //{
                
            //    string[] tokens = input.Split('|');

            //    string command = tokens[0];

            //    if (command == "Move")
            //    {
            //        int numOfLetter = int.Parse(tokens[1]);


            //        for (int i = 0; i < numOfLetter; i++)
            //        {
            //           char help = sb[0]; 

            //            sb.Append(help);
            //            sb.Remove(0, 1);
            //        }
            //    }
            //    else if (command == "Insert")
            //    {
            //        int index = int.Parse(tokens[1]);
            //        string value = tokens[2];

                    
            //       sb.Insert(index, value);
                    
            //    }
            //    else if (command == "ChangeAll")
            //    {
            //        string substring = tokens[1];
            //        string replacement = tokens[2];

            //       sb.Replace(substring, replacement);
            //    }


            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"The decrypted message is: {sb}");



        }
    }
}
