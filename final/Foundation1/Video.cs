using System;

public class Video
{
    public string Title, Author;
    public int length;
    

    public List<Comments> CommentsList = new List<Comments>();

    public Video(string _title, string _author, int _lenght)
    {
        Title = _title;
        Author = _author;
        length = _lenght;
    }
   
    public int CountComments()
    {
        return CommentsList.Count();
    }
    
    public void DisplayCommentList()
    {
        Console.WriteLine(CommentsList );
    }


    //sets text format for displayed info
    public string DisplayVideoInfo()
    {
        return String.Format("Title: {0}, Author: {1}, Length: {2}, Comments: {3}", Title, Author, length, CountComments());
    
    }
    
 
}