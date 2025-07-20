using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("The Secret Life of Cats", "CatLover99", 300);
        video1.AddComment(new Comment("Alice", "This video is so adorable!"));
        video1.AddComment(new Comment("Bob", "I learned a lot about cat behavior."));
        video1.AddComment(new Comment("Charlie", "Meowtastic content!"));
        videoList.Add(video1);

        Video video2 = new Video("Top 10 Coding Tips", "DevMaster", 600);
        video2.AddComment(new Comment("Dan", "Tip #7 saved me hours!"));
        video2.AddComment(new Comment("Eve", "Great stuff for beginners."));
        video2.AddComment(new Comment("Frank", "I want more Python tips."));
        videoList.Add(video2);

        Video video3 = new Video("Epic Mountain Biking", "TrailHunter", 450);
        video3.AddComment(new Comment("Grace", "The aerial shots are stunning!"));
        video3.AddComment(new Comment("Henry", "Where is this trail located?"));
        video3.AddComment(new Comment("Ivy", "Now I want to try biking."));
        videoList.Add(video3);

        Video video4 = new Video("Baking Banana Bread", "KitchenQueen", 360);
        video4.AddComment(new Comment("Jack", "I baked along—delicious!"));
        video4.AddComment(new Comment("Kara", "Clear instructions, thanks."));
        video4.AddComment(new Comment("Liam", "Can you do brownies next?"));
        videoList.Add(video4);

        foreach (var video in videoList)
        {
            video.DisplayInfo();
        }
    }
}
