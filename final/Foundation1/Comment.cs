using System;

public class Comments
{
    public string Comment, Name, CommentText;

    //public List<string> CommentsList = new List<string>();
    
    public Comments(string _Name, string _CommentText)
    {
        Name = _Name;
        CommentText  = _CommentText;
    }
    public string FormatCommentInfo()
    
    {
        return string.Format("\t- {0} \n \t- '{1}'", Name, CommentText);
    
    }



}