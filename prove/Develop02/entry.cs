using System;

public class Entry
{
    //entry class will store user's input
    //states

    //string name for user's input
    private string _Entry;

    //behavior method:

    //1.Display or print the users entry:
    public void ShowEntry()
    {
        Console.WriteLine($"{_Entry}");
    }

    //2.Saves users entry
    public void setEntry()
    {
        Console.WriteLine($"{_Entry}");
    }

    public string getEntry()
    {
        return _Entry;
    }


}




