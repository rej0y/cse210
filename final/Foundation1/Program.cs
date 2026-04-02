using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Relaxing Rain Sounds for Sleep",
            "NatureChannel",
            3600
        );
        video1.AddComment(new Comment("Mia", "This helped me fall asleep instantly."));
        video1.AddComment(new Comment("Noah", "So calming 😌"));
        video1.AddComment(new Comment("Ava", "I play this every night!"));
        videos.Add(video1);


        Video video2= new Video(
            "Street Food Tour in Tokyo",
            "TravelBites",
            900
        );
        video2.AddComment(new Comment("Liam", "Everything looks so delicious!"));
        video2.AddComment(new Comment("Sophia", "I want to visit Japan now."));
        video2.AddComment(new Comment("Ethan", "That ramen looked amazing!"));
        videos.Add(video2);


        Video video3 = new Video(
            "Amazing Space Facts You Didn’t Know",
            "CosmicWorld",
            720
        );
        video3.AddComment(new Comment("Olivia", "Space is mind-blowing."));
        video3.AddComment(new Comment("Lucas", "I didn’t know that about black holes!"));
        video3.AddComment(new Comment("Emma", "Great visuals!"));
        videos.Add(video3);


        Video video4 = new Video(
            "DIY Room Makeover on a Budget",
            "CreativeHome",
            840
        );
        video4.AddComment(new Comment("Chloe", "I’m trying this this weekend!"));
        video4.AddComment(new Comment("Mason", "Looks so clean and simple."));
        video4.AddComment(new Comment("Ella", "Love the ideas!"));
        videos.Add(video4);


        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("\n");
        }
    }
}