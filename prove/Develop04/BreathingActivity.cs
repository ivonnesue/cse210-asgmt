using System;
using System.Diagnostics;

public class BreathingActivity :  Activity
{
    //private string instruction1, instruction2;

    public BreathingActivity() : base()
    {
        setActivityName("Breathing Activity");

        setDescription("This Activity will help you relax"+
        " by walking you through breathing in and breathing out slowly." +
        " Clear your mind and foucs on your breathing");

    }

    public void setBreathingCounter(int numSecondstoRun)
    {
        for (int i = 1; i<= numSecondstoRun; i++)
        {
            Console.WriteLine(string.Format("{0}", i));
            //Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);

            
        }
    }

    public void displayInstructions()
    {
        int userListingTime = getUserInputTime();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while(stopwatch.ElapsedMilliseconds / 1000 < userListingTime)
        {
            Console.Write("Breath in...");
            Console.WriteLine();

            setBreathingCounter(4);

            Console.WriteLine();

            Console.WriteLine("Now breath out...");
            setBreathingCounter(4);
            
            Console.WriteLine();
        }
          
    }
    public void RunBreathingAct()
    {
        runActivityParentStart();
        displayInstructions();

        runActivityParentEnd();
    }
}
