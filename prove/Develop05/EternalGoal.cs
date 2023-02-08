using System;

public class EternalGoal : BaseGoal

{   
    private const int goalType = 2;

    private bool goalComplete;


    public EternalGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete)
    : base(_goalName, _goalDescription, _points)
    {
        goalComplete = _goalComplete;
    }

    public override void ToCSVRecord()
    {
        return string.Format("{0}|{2}|{3}}{4}", goalType, getGoalName(), getDescription(), getPoints(), goalComplete);

    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", ((goalComplete == false)? " ": "X"),
        getGoalName(), getDescription());
    }
    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulation! You have earned {0}", getPoints()));
        goalComplete = true;
    }
}
