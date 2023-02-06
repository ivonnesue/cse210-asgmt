using System;

public class EternalGoal : BaseGoal
{
    private bool goalComplete;
    public EternalGoal(string goalName, string Goaldescription, int points, bool _goalComplete ) 
    : base(goalName, Goaldescription, points)
    {
        goalComplete = _goalComplete;
        
    }

    


}

