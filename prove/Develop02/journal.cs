using System;
using System.IO;
public class Journal
{
    private string _filename;

    //declare the type of data (DateTime)
    private DateTime _date = DateTime.Now;

    private string _file;
 
    private string _dateText;

    private string _userEntry;

    //class methods
    List<string> entriesList = new List<string>();
    public void addEntry()
    {
        //prints 
        Console.Write("Write your entry");
        string write = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry._Entry = _userEntry;


    }
    public void setFilename()
    {
        Console.WriteLine("Enter file name");
        _filename = Console.ReadLine();
    }

    public string getFilename()
    {
        return _filename;
    }

    public void setDate()
    {
        _dateText = _date.ToShortDateString();
    }
    
    public string getDate()
    {
        return _dateText;
    }

    public void loadfile()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
    //saves file using user input from main program 
     public void Savefile(string _input)
    {
        using (StreamWriter outFile = new StreamWriter(_filename))
        {
            outFile.WriteLine(_input);
        }
        
    }
    
}
