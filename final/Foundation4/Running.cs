using System;

public class Running : Activity
{
    private int NumOflaps =0;

    public Running (int _NumOflaps, int _timeInMins ) : base()
    {
        NumOflaps = _NumOflaps;

        setActityType("Running");

        timeInMins = _timeInMins;
    }

    public int getNumofLaps()
    {
        return NumOflaps;
    }
    public override double CalculateDistanceKM()
    {
        //Calcualtes the distance in kilometers.
        //in a 200m indoor running track
    
        base.setDistance(getNumofLaps() * 200.0 /1000);
        return base.CalculateDistanceKM();
    }

    public override double CalculateSpeedKPH()
    {
       
        
        //sets speed attribute value by calculating
        //the value of distance divided by the value of Time * 60
        base.setSpeed(CalculateDistanceKM() / getTime() * 60);
        return base.CalculateSpeedKPH();

        
    }

    public override double calculatePace()
    {
        base.setPace(getTime() / CalculateDistanceKM());
        return base.calculatePace();
    }
        
        
    
}