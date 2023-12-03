using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("How to Juggle", "Mr. Clown", 139);
        video1.AddComment("HourGifted", "Thanks, it was very helpful!");
        video1.AddComment("YetBandana", "I have always wanted to learn how to do this!");
        video1.AddComment("UnifySwift", "How many pins can you juggle with?");

        Video video2 = new Video("How to Edit a Video", "The Editor", 246);
        video2.AddComment("WhereWhose", "How does the greenscreen work?");
        video2.AddComment("ImmediateSupposing", "Nice video!");
        video2.AddComment("IndeedIndeed", "How many videos have you made?");

        Video video3 = new Video("Coding for Beginners", "The Programmer", 187);
        video3.AddComment("AboveAbout", "Thanks! I have been trying to figure this out for a long time!");
        video3.AddComment("PlusRunway", "How many programming languages do you know?");
        video3.AddComment("WhoSo", "Can you share more videos about this?");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}