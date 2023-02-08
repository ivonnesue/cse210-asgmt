using System;

public abstract class BaseGoal
{
    
    private string _goalName, _goalDescription;
    int _points, _goalType;

    public BaseGoal()
    {
    }

    public BaseGoal(string goalName, string goalDescription, int goalType)
    { 
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalType = goalType = 0;

    }

 
    public void setPoints(int points)
    {
        _points = points;
    }

    public int getPoints()
    {
        return _points;
    }

    
    public void setGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public string getGoalName()
    {
        return _goalName;
    }
    public void setDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }
    
    public string getDescription()
    {
        return _goalDescription;
    }
    public void askforGoalName()
    {
        Console.WriteLine("What is the name of your goal? ");
        setGoalName(Console.ReadLine()); 
    }   
    public void askForDescription()
    {
        Console.Write("Add a short description about your goal ");
        setDescription(Console.ReadLine());
    
    }

    public int askForPoints(int _points)
    {
        Console.WriteLine("How many points is this goal worth?")
        _points = int.Parse(Console.ReadLine());

        return _points;
    }
    public void DisplayPoints()
    {
        Console.WriteLine(getPoints());
    }

    public abstract void RecordEvent();

    public abstract string ToCSVRecord();
   
    public void runGoalProgram()
    {
        askforGoalName();
        askForDescription();
     
    }

}

