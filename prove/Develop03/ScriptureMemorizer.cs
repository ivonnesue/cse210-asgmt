using System;

class ScriptureMemorizer
{
    private Scripture scripture;

    private List<string> scritpureTextList;
    
    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scritpureTextList = new List<string>();
        convertTexttoList();
    }

    private void convertTexttoList()
    {
        scritpureTextList = scritpureTextList.ToString().Split(' ').ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = new Random().Next(3);
        int wordsRemoved = 0;

        do 
        {
            int randomIndex = new Random().Next(0, scritpureTextList.Count());
            
            scritpureTextList[randomIndex] = new string('_', scritpureTextList[randomIndex].Length);
            wordsRemoved++;

        }while (wordsRemoved != numWordsToRemove);

    }
    
    public string toString()
    {
        return string.Join(' ', scritpureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retvalue = false;
        
        foreach (string word in scritpureTextList)
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