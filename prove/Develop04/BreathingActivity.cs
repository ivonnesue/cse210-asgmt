using System;
using System.Diagnostics;

public class BreathingActivity :  Activity
{
    private string instruction1, instruction2;

    public BreathingActivity() : base()
    {
        setActivityName("Breathing Activity");

        setDescription("This Activity will help you relax by"+
        "by walking you through breathing in and breathing out slowly." +
        "Clear your mind and foucs on your breathing");

        //instruction1 = "Breath in...";
        //instruction2 = "Now breath out...";

    }

    public void setBreathingCounter(int numSecondstoRun)
    {
        for (int i = 1; i<= numSecondstoRun; i++)
        {
            Console.Write(string.Format("{0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
    public string getInstruction1()
    {
        return instruction1;
    }

    public string getInstruciton2()
    {
        return instruction2;
    }

    public void displayInstructions()
    {
        int userListingTime = getUserInputTime();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while(stopwatch.ElapsedMilliseconds / 1000 < userListingTime)
        {
            Console.WriteLine(getInstruction1());
            setBreathingCounter(4);

            Console.WriteLine(getInstruciton2());
            setBreathingCounter(6);
            
        }
          
    }
    public void RunBreathingAct()
    {
        runActivityParentEnd();
        displayInstructions();

        runActivityParentEnd();
    }
}
