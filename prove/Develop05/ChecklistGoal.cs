using System;

public class ChecklistGoal : BaseGoal
{
    private bool goalComplete;

    private int goalFrequency, bonusAmount;
    public ChecklistGoal(string _goalName, string _Goaldescription, int points, bool _goalComplete) 
    : base(_goalName, _Goaldescription, points)
    {
        goalComplete = _goalComplete;
    }

    public void getGoalFrenquency()
    {

    }

    



}
