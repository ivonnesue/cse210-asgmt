using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> listingPromptList;

    public ListingActivity() : base()
    {
        setActivityName("Listing Activity");

        setDescription("This activity will help you reflect"+
        "on the good things in your life by having you list" +
        "as many as you can in a certain area");

        listingPromptList = new List<string>
        {
            "- Who are the people that you appreciate",
            "- What are personal strengths of yours?",
            "- When have you felt the Holy Ghost this month?",
            "- Who are some of your personal heroes?"
        };

        
    }

    public string getRandomListingPrompt()
    {
        var randomPrompt = new Random();
        int index = randomPrompt.Next(listingPromptList.Count());
        return listingPromptList[index];
    }

    public void showListingRandomPrommpt()
          
    {
        Console.WriteLine("List as many respones as you can to the following prompt");
        Console.WriteLine();

        Console.WriteLine(getRandomListingPrompt());

        DisplayCountdown(5);
        Console.WriteLine();
        string userAnswer = "";
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while(stopwatch.ElapsedMilliseconds / 1000 < getUserInputTime())
        {
           Console.Write("> ");
           userAnswer = Console.ReadLine();
        
        }

        //the following code did not work:
        List<string> Answerslist = new List<string>();
        userAnswer.Add()
        //string userAnswer = "";

        //for (int i = 0; i < 4; i++)
        //{
        //    Console.Write("> ");
        //    userAnswer = Console.ReadLine();
        //}
        //
        //foreach (int index in Answerindexes)
        //{
        //    
        //}
        //   
    }
    public void runListingActivity()
    {
        runActivityParentStart();
        showListingRandomPrommpt();
        runActivityParentEnd();
    }
}

