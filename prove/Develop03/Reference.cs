
using System;

class Reference
{
    //attributes
    private string book;
    private string chapter;
    private string verse;

    //constructor
    public Reference (string _book, string _chapter, string _verse)
    {
        book    = _book;
        chapter = _chapter;
        verse   = _verse;
    }

    //methods
    
    
    public string toString()
        {
    //keeps track of book, chapter, and verse, and retuns a string
    //that can be used to print it later.
    //Converts the value of objects to strings based on the formats 
    //specified and inserts them into another string.
            return string.Format("{0} {1}:{2}", book, chapter, verse);
        }
    
}
