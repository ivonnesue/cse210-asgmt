using System;

public abstract class BaseGoal
{
    
    private string _goalName, _goalDescription;
    protected int _points, _goalType, BonusPoints, GoalFrequency;

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

    public int getBonusPoints()
    {
        return BonusPoints;
    }
    
    public void setBonusPoints(int _bonusPoints)
    {
        BonusPoints = _bonusPoints;
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
        Console.WriteLine("How many points is this goal worth?");
        _points = int.Parse(Console.ReadLine());

        return _points;
    }
    public void DisplayPoints()
    {
        Console.WriteLine(getPoints());
    }

    public void DisplayGetFrequencyAmount()
    {
        Console.WriteLine("How many times does this goal need to be accomplished" +
        "to get a bonus?");
        GoalFrequency = int.Parse(Console.ReadLine());
    
    }

    public void DisplayGetBonusPoints()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many time?");
        bonusPoints = int.Parse(Console.ReadLine());
    }
    public abstract void RecordEvent();

    public abstract string ToCSVRecord();
   
    public void runGoalProgram()
    {
        askforGoalName();
        askForDescription();
     
    }

}

