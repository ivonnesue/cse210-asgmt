using System;

public class Swimming : Activity
{
    private int SwimmingLaps = 0;
    
    public Swimming (int _Swimminglaps, int _timeInMins ) : base()
    {
        SwimmingLaps = _Swimminglaps;

        setActityType("Swimming");

        timeInMins = _timeInMins;
    }

    public int getNumofSwimmingLaps()
    {
        return SwimmingLaps;
    }

    public override double CalculateDistanceKM()
    {
        //Calculate the distance in kilomenters
        //in an 50 meter indoor pool
        base.setDistance(getNumofSwimmingLaps() * 50.0 /1000); 
        return base.CalculateDistanceKM();
    }

    public override double CalculateSpeedKPH()
    {
        
        base.setSpeed(CalculateDistanceKM() / getTime() * 60);
        return base.CalculateSpeedKPH();
        
    }

    public override double calculatePace()
    {
        base.setPace(getTime() / CalculateDistanceKM());
        return base.calculatePace();
    }
}