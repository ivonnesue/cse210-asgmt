using System;

public class SimpleGoal : BaseGoal
{
    private bool goalComplete;

    //public SimpleGoal()
    //{
//
    //}

    public SimpleGoal(string _goalName, string _Goaldescription, int points, bool _goalComplete) 
    : base(_goalName, _Goaldescription, points)
    {
        goalComplete = _goalComplete;
    }

   
}

