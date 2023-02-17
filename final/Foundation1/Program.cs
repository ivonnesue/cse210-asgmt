using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Console.WriteLine("Welcome to the Video Tracker");
        Console.WriteLine();
    
        Video video1 = new Video("Video 1", "John Doe", 60);

        video1.Title = "Video1";
       
        Comments comment1 = new Comments("user001", "Fantastic");
        Comments comment2 = new Comments("user002 ", "Awesome");
        Comments comment3 = new Comments("user003", "I really like it");
        video1.CommentsList.Add(comment1);
        video1.CommentsList.Add(comment2);
        video1.CommentsList.Add(comment3);

        //video1.CommentsList.AddRange();

        Video video2 = new Video("Video 2", "Jane Doe", 30);
        
        Comments Comment1V2 = new Comments("user 001", "Awesome");
        Comments Comment2V2 = new Comments("user002", "Interesting");
        Comments Comment3V2 = new Comments("user 003", "That's funny!" );
        video2.CommentsList.Add(Comment1V2);
        video2.CommentsList.Add(Comment2V2);
        video2.CommentsList.Add(Comment3V2);
     

        Video video3 = new Video("Video 3", "Juan Gonzalez", 120);
        
        Comments Comment1V3 = new Comments("user 001", "Wow!");
        Comments Comment2V3 = new Comments("user002", "No Way!");
        Comments Comment3V3 = new Comments("user 003", "How did you do that?" );
        video3.CommentsList.Add(Comment1V3);
        video3.CommentsList.Add(Comment2V3);
        video3.CommentsList.Add(Comment3V3);
        

        List<Video> VideosList = new List<Video>();
        VideosList.Add(video1);
        VideosList.Add(video2);
        VideosList.Add(video3);


        foreach (Video video in VideosList)
        {
            Console.WriteLine(video.DisplayVideoInfo());
            foreach (Comments comment in video.CommentsList)
            {
                Console.WriteLine(comment.FormatCommentInfo());
                Console.WriteLine();
            }
            
        }



    }
}