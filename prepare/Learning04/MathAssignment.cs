using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    //constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    
//setters and getters
    public void setTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string getTextbookSection()
    {
        return _textbookSection;
    }

    public void setProblems(string problems)
    {
        _problems = problems;
    }
    
    public string getProblems()
    {
        return _problems;
    }

    public string getHomeworkList()
    {
        return $"Section: {_textbookSection}, Problems {_problems}";
    }
}