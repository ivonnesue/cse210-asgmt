using System;

public class Entry
{
    //entry class will store user's answer, date and prompts
    //states

    //string name for user's input
    public string _Entry = "";
    public string _Prompts = "";

    public string _date = "";

    //behavior method:

    //does Entry class sets and gets the data types:
    //entry, prompts and date?

    //set entry
       public void setEntry()
    {
        Console.WriteLine($"{_Entry}");
    }

    public string getEntry()
    {

       return _Entry;
    }

    //2.Saves users entry
 
    //.Display or print the users entry:
    public void ShowEntry()
    {
        Console.WriteLine($"{_Entry}");
    }


}




