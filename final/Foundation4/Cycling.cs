using System;

public class Cycling : Activity
{
    private double TireRadius;
    private double NumOfRevolutions;

    private double circumference;

    public Cycling(double _TireRadius, double _NumOfRevolutions, int _timeInMins)
    {
        TireRadius = _TireRadius;
        NumOfRevolutions = _NumOfRevolutions;
        timeInMins = _timeInMins;
    }


    //If company needed the app to calculate the distance, speed, and pace from
    //scratch, it may need to use the tire radius of a bike to calculate
    //the circumference. Then, use the circumference and number of revolutions to calculate distance.

    
    public double getNumOfRevolutions()
    {
        return NumOfRevolutions;
    }
    
    //tireRadius in meters
    public double calculateCircumference()
    {   
        circumference =  2  * Math.PI * TireRadius;
        return circumference;
    }
    

    public override double CalculateDistanceKM()
    {
        //calculate distance in Km using the circumference of tire bike,
        //multiplied by the number of revolutions of the tire, divided by 1000.
        base.setDistance(calculateCircumference() * getNumOfRevolutions() /1000);    
        return base.CalculateDistanceKM();
    }

    public override double CalculateSpeedKPH()
    {
        //calculates speed using distance divided by exercise time
        base.setSpeed(CalculateDistanceKM() / getTime() * 60);
        return base.CalculateSpeedKPH();
    }

    public override double calculatePace()
    {
        //calculates pace using time divided by distance
        base.setPace(getTime() / CalculateDistanceKM());
        return base.calculatePace();
    }

    //distance = circumference * NumOfRevolutions / 1000

}