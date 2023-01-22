using System;

class ScriptureMemorizer
{
    //attributes
    private Scripture scripture;

    private List<string> scriptureTextList;
    
    //constructor
    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }
    //splits scriptureTextList words and stores them in a list
    private void convertTextToList()
    {
        scriptureTextList = scripture.toString().Split(' ').ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do 
        {
            int randomIndex = new Random().Next(0, scriptureTextList.Count());
            
            if (scriptureTextList[randomIndex].Contains('_') == false)
            {
                scriptureTextList[randomIndex] = new string('_', scriptureTextList[randomIndex].Length);
                wordsRemoved++;
            }

        }while (wordsRemoved != numWordsToRemove);

    }
    
    public string toString()
    {
        return string.Join(' ', scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retvalue = false;
        
        foreach (string word in scriptureTextList)
        {
            if (word.Contains('_') == false)
            {
                retvalue = true;
                break;
            }
        }

        return retvalue;
    }
   

}