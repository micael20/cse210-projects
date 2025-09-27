using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");


{

        // Create videos
        Video video1 = new Video("C# Tutorial", "Bob Dev", 600);
        Video video2 = new Video("OOP Principles", "Alice Code", 800);
        Video video3 = new Video("Data Structures", "Michael Mwodete", 750);
        
        // Add comments to video1
            video1.AddComment(new Comment("John", "Great tutorial!"));
            video1.AddComment(new Comment("Sarah", "Very helpful for beginners"));
            video1.AddComment(new Comment("Mike", "When is part 2 coming?"));
        
        // Add comments to video3
            video3.AddComment(new Comment("Alice", "Loved the explanation on trees!"));
            video3.AddComment(new Comment("Bob", "Can you cover graphs next?"));
        
        // Add comments to video2  
            video2.AddComment(new Comment("Emma", "Finally understand encapsulation!"));
            video2.AddComment(new Comment("Tom", "Clear examples, thank you!"));
        
        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2 };
        
        // Display each video's info
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo(); 
        }
    }
}
    }
