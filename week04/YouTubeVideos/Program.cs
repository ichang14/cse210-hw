using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Learn C# Basics", "Ilich Chang", 600);
        Video v2 = new Video("Object-Oriented Programming", "Ilich Chang", 900);
        Video v3 = new Video("Programming Tips", "Ilich Chang", 750);

        v1.AddComment(new Comment("John", "Great video!"));
        v1.AddComment(new Comment("Emily", "Very helpful explanation"));
        v1.AddComment(new Comment("Michael", "I learned a lot"));

        v2.AddComment(new Comment("Sarah", "Awesome content"));
        v2.AddComment(new Comment("David", "Clear and easy to follow"));
        v2.AddComment(new Comment("Laura", "Thanks for this!"));

        v3.AddComment(new Comment("Carlos", "Nice tips!"));
        v3.AddComment(new Comment("Ana", "Very useful"));
        

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");

            Console.WriteLine("Comments:");
            v.DisplayComments();

            Console.WriteLine("---------------------------");
        }
    }
}