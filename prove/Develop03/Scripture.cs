using System;

class Scripture
{   
    //attributes
    private string scriptureText;

    //links or gets access to data in Reference class
    private Reference scriptureReference;

    //constructor

    public Scripture(Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        scriptureText = _scriptureText;
    }

    //method

    public string toString()
    {
        return string.Format("{0}", scriptureText);
    }
}