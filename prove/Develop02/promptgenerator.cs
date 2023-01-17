using System;
using System.Collections.Generic;
public class PromptGenerator
{
    //states
    public string _Prompts;

    private List<string> promptsList = new List<string>();

    //constructor 
    public PromptGenerator()
    {
        promptsList.Add("How did you overcome an obstacle today?");
        promptsList.Add("Highlight from the day, big or small");
        promptsList.Add("What did you eat today?");
        promptsList.Add("What did you learn from the scriptures today?");
        promptsList.Add("What are you gratefull for?");
    }

    public void ShowPrompts()
    {
        Console.WriteLine($"{promptsList}");
    }

    
}
   



    //Behavior methods:
    //1.Create a list of prompts as strings

    
