using System;
using System.Collections.Generic;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            
            //List<Article> articles = new List<Article>();

            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] change = Console.ReadLine().Split(": ");

                
                if (change[0] == "Edit")
                {
                   article.Edit(change[1]);
                }
                else if (change[0] =="ChangeAuthor")
                {
                    article.ChangeAuthor(change[1]);
                }
                else if (change[0] == "Rename")
                {
                   article.Rename(change[1]);
                }

            }

            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article(string title,string content,string author)
        {
            this.Title = title; 
            this.Content = content;
            this.Author = author;
        }


        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
             return $"{Title} - {Content}: {Author}";
        }
    }
}
