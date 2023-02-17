using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Console.WriteLine("Welcome to the Video Tracker");
        Console.WriteLine();
    
        List<Video> VideosList = new List<Video>{
            new Video("Video 1", "John Doe", 60), 
            new Video("Video 2", "Jane Doe", 30),
            new Video("Video 3", "Juan Gonzalez", 120)
        };


        List<Comments>newList = new List<Comments>
        {
            new Comments("user001", "Fantastic"),
            new Comments("user002", "Awesome"),
            new Comments("user001", "I really like it!"),
        };
        VideosList[0].CommentsList.AddRange(newList);
      
        newList = new List<Comments>
        {
            new Comments("user 001", "Awesome"),
            new Comments("user002", "Interesting"),
            new Comments("user 003", "That's funny!"),
        
        };
        VideosList[1].CommentsList.AddRange(newList);
        
        newList = new List<Comments>
        {
            new Comments("user 001", "Wow!"),
            new Comments("user002", "No Way!"),
            new Comments("user 003", "How did you do that?"),
        };
        VideosList[2].CommentsList.AddRange(newList);

        
        foreach (Video video in VideosList)
        {
            Console.WriteLine(video.DisplayVideoInfo());
            video.DisplayCommentList();
            
        }



    }
}