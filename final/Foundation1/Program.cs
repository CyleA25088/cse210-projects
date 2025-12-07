using System;
using System.Collections.Generic;

class Program
{
    private static List<Video> _videos = new List<Video>();

    private static void CreateSampleVideos()
    {

        // ===== VIDEO 1 =====
        Video video1 = new Video("My First Video", "Jake", 120);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Sarah", "Loved the explanation."));
        video1.AddComment(new Comment("Tom", "Awesome work!"));
        _videos.Add(video1);

        // ===== VIDEO 2 =====
        Video video2 = new Video("Learning C#", "Noah", 180);
        video2.AddComment(new Comment("Jake", "This made sense, thanks!"));
        video2.AddComment(new Comment("Emma", "Do more tutorials please."));
        video2.AddComment(new Comment("Chris", "I finally understand classes."));
        video2.AddComment(new Comment("Anna", "Great pace and detail."));
        _videos.Add(video2);

        // ===== VIDEO 3 =====
        Video video3 = new Video("OOP Basics", "Sarah", 240);
        video3.AddComment(new Comment("Liam", "Nice breakdown!"));
        video3.AddComment(new Comment("Mia", "Helpful example."));
        video3.AddComment(new Comment("Noah", "Thanks for the clarity."));
        video3.AddComment(new Comment("Ella", "Really well explained."));
        _videos.Add(video3);
    }

    private static void DisplayAllVideos()
    {
        foreach (var video in _videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        CreateSampleVideos();
        DisplayAllVideos();
    }
}
