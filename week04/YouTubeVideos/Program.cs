using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("10 Things You Didn't Know About the Ocean", "OceanExplorer", 542);
        video1.AddComment(new Comment("SarahSwims",    "I had no idea the ocean was so deep in some places!"));
        video1.AddComment(new Comment("Jake_Dives",  "Number 7 blew my mind. Great video!"));
        video1.AddComment(new Comment("TinaWaves",   "Could you do one about freshwater ecosystems too?"));
        video1.AddComment(new Comment("NeilFish",    "The part about bioluminescence was my favorite."));
        
        Video video2 = new Video("How to Make the Perfect Sourdough Bread", "BreadWithBen", 1203);
        video2.AddComment(new Comment("FoodLover99",   "I tried this recipe and it turned out amazing!"));
        video2.AddComment(new Comment("CrunchyCrust",  "Finally a tutorial that explains the starter properly."));
        video2.AddComment(new Comment("GlutenFreeMeg", "Do you have a gluten-free version of this?"));
        
        Video video3 = new Video("Beginner's Guide to C# Programming", "CodeAcademy", 876);
        video3.AddComment(new Comment("Dev_Mike",    "This helped me understand classes so much better."));
        video3.AddComment(new Comment("LearnerLisa", "I watched this three times and finally get it now!"));
        video3.AddComment(new Comment("BugHunter42", "Great explanation of abstraction at the 12 minute mark."));
        video3.AddComment(new Comment("StudentPro",  "Best free C# tutorial on YouTube, no question."));
        
        Video video4 = new Video("Top 5 Hiking Trails in Utah", "TrailBlazers", 389);
        video4.AddComment(new Comment("HikingHannah", "Angel's Landing is worth every step!"));
        video4.AddComment(new Comment("OutdoorOscar",  "I live in Utah and still learned about new trails here."));
        video4.AddComment(new Comment("NatureFanatic", "Could you do a video on the best trails for beginners?"));
        
        
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        
        
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}