using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Console.WriteLine("Welcome to the Video Tracker");
        Console.WriteLine();
    
        Video video1 = new Video("Video 1", "John Doe", 60);
       
        /*Comments comment1 = new Comments("user001", "Fantastic");
        Comments comment2 = new Comments("user002 ", "Awesome");
        Comments comment3 = new Comments("user003", "I really like it");
        video1.CommentsList.Add(comment1);
        video1.CommentsList.Add(comment2);
        video1.CommentsList.Add(comment3);*/

        //video1.CommentsList.AddRange();

        video1.CommentsList.Add(new Comments("user001", "Fantastic"));
        video1.CommentsList.Add(new Comments("user002", "Awesome"));
        video1.CommentsList.Add(new Comments("user001", "I really like it!"));

        Video video2 = new Video("Video 2", "Jane Doe", 30);
        
        video2.CommentsList.Add(new Comments("user 001", "Awesome"));
        video2.CommentsList.Add(new Comments("user002", "Interesting"));
        video2.CommentsList.Add(new Comments("user 003", "That's funny!"));
        
      

        Video video3 = new Video("Video 3", "Juan Gonzalez", 120);

        video3.CommentsList.Add(new Comments("user 001", "Wow!"));
        video3.CommentsList.Add(new Comments("user002", "No Way!"));
        video3.CommentsList.Add(new Comments("user 003", "How did you do that?"));


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