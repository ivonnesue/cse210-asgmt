using System;

public class BaseGoal
{
    private string goalName, Goaldescription;
    private int points;

    public BaseGoal(string _goalName, string _Goaldescription, int points)
    {
        goalName = _goalName;
        Goaldescription = _Goaldescription;
        points = 0;
    }

    public void setGoalName(string _goalName)
    {
        goalName = _goalName;
    }

    public void setDescription(string _Goaldescription)
    {
        Goaldescription = _Goaldescription;
    }

    public void RecordEvent()
    {

    }

    public void calculateScore()
    {
        
    }

    public void runProgram()
    {
        
    }

    //public virtual string toCSVRecord(string fileName)
    //{

    //}



}