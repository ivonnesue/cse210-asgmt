using System;
using System.Diagnostics;
public class Activity
{
    //attributes
    private string _activityName, _startMessage, _description, _endMessage;
    static int _sessionLenght, _spinnerCounter;

    public Activity()
    {
        _spinnerCounter = _sessionLenght = 0;
    }

    public void setActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void setDescription(string description)
    {
        _description = description;
    }
      public int getUserInputTime()
    {
        return _sessionLenght;
    }
    public void askForDuration()
    {
        Console.Write("How long in seconds, would you like your session? ");
        _sessionLenght = int.Parse(Console.ReadLine());
    
    }

  
    public void showStartingMessage()
    {
        _startMessage = string.Format("Welcome to the {0} Activity", _activityName);
        Console.WriteLine(_startMessage);
        Console.WriteLine();
    }

    public void showDescription()
    {
        Console.Write(_description);
        Console.WriteLine();
    }
    public void showSpinner(int numSecondstoRun)
    {
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while(stopwatch.ElapsedMilliseconds / 1000 < numSecondstoRun)
        {
            _spinnerCounter++;
            switch(_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

    }

    public void showGetReady()
    {
        Console.WriteLine("Get ready in...");
        showSpinner(3);
    }

    public void DisplayCountdown(int numSecondstoRun)
    {
        for (int i = 1; i<= numSecondstoRun; i++)
        {
            Console.Write(string.Format("you may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void showEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        _endMessage = string.Format("You have completed another {0} seconds of the {1}", _sessionLenght, _activityName);
        showSpinner(10);
        Console.WriteLine(_endMessage);
        Console.WriteLine();
        showSpinner(10);
    }

    public void runActivityParentStart()
    {
        showStartingMessage();
        showDescription();
        askForDuration();
        showGetReady();
        DisplayCountdown(5);
      
    }

    public void runActivityParentEnd()
    {
        showEndingMessage();
    }
}