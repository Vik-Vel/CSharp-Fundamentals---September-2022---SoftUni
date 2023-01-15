using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                
                string[] tokens = command.Split(":");

                string lessonsCurrName = tokens[1];

                if (tokens[0] == "Add" && !lessons.Contains(lessonsCurrName))
                {
                    lessons.Add(tokens[1]);
                }

                else if (tokens[0] == "Insert" && !lessons.Contains(lessonsCurrName))
                {
                    string lessonTitle = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (index < 0 || index >= lessons.Count)
                    {
                        return lessons;
                    }
                    else 
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(index, lessonTitle);
                    }
                }

                else if (tokens[0] == "Remove" && lessons.Contains(lessonsCurrName))
                {
                   
                    lessons.Remove(lessonsCurrName);

                    if (lessons.Contains(lessonsCurrName))
                    {
                        lessons.Remove(lessonsCurrName);
                    }
                    else if (lessons.Contains(lessonsCurrName + "-Exercise"))
                    {
                        lessons.Remove(lessonsCurrName +"-Exercise");
                    }
                }

                else if (tokens[0] == "Exercise" && !lessons.Contains(lessonsCurrName))
                {
                    string lessonTitle = tokens[1];

                    if (lessons.Contains(lessonTitle) && !lessons.Contains(lessonTitle + "-Exercise"))
                    {
                        int index = lessons.IndexOf(lessonTitle);
                        lessons.Insert(index + 1, lessonTitle + "-Exercise");
                    }
                    else if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(lessonTitle + "-Exercise");
                    }
                }

                


                else if (tokens[0] == "Swap" && lessons.Contains(tokens[1]))
                {
                    string currNameOnFirst = lessonsCurrName;
                    string currNameOnLast = tokens[2];
                    
                    int index1 = lessons.IndexOf(currNameOnFirst);
                    int index2 = lessons.IndexOf(currNameOnLast);


                    if (lessons.Contains(currNameOnFirst) && lessons.Contains(currNameOnLast))
                    {
                        string tempLessonT1 = lessons.ElementAt(index1);
                        lessons[index1] = lessons[index2];
                        lessons[index2] = tempLessonT1;
                    }

                    if (lessons.Contains(currNameOnFirst + "-Exercise") && lessons.Contains(lessons[index1]))
                    {
                        index1 = lessons.IndexOf(currNameOnFirst);
                        lessons.Remove(currNameOnFirst + "-Exercise");
                        lessons.Insert(index1 + 1, currNameOnFirst + "-Exercise");

                    }

                    else if (lessons.Contains(currNameOnLast + "-Exercise") && lessons.Contains(lessons[index2]))
                    {
                        index2 = lessons.IndexOf(currNameOnLast);
                        lessons.Remove(currNameOnLast + "-Exercise");
                        lessons.Insert(index2 + 1, currNameOnLast + "-Exercise");
                    }
                }





                command = Console.ReadLine();


            }

            int count = 0;
            foreach (var lesson in lessons)
            {
                count++;
                Console.WriteLine($"{count}.{lesson}");
            }
        }
    }
}
