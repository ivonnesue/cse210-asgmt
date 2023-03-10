using System;

public class Activity
{
    private string date, activityType;
    protected int timeInMins;
    private double speed, distance, pace;



    public Activity()
    {

    }

    public Activity(double _speed, double _distance, double _pace)
    {
        speed = _speed;
        distance = _distance;
        pace = _pace;
        //date = DateTime.Today.ToString("dd/MM/yyyy");
    }
    /*public Activity(string _date, string _activityType, int _timeInMins)
    {
        date = _date;
        activityType = _activityType;
        timeInMins = _timeInMins = 0;
    }*/ 

    public void setDate(string _date)
    {
        date = _date;
    }
    public string getDate()
    {
        return date = DateTime.Today.ToString("dd/MM/yyyy");
    }
    public void setTime(int _timeInMins)
    {
        timeInMins = _timeInMins;
    }

    public int getTime()
    {
        return timeInMins;
    }
    public void setSpeed(double _speed)
    {
        speed = _speed;
    }

    public void setDistance(double _distance)
    {
        distance = _distance;
    }

    public void setPace(double _pace)
    {
        pace = _pace;
    }

    public void setActityType(string _activityType)
    {
        activityType = _activityType;
    }
    //Calculate distance
    public virtual double CalculateDistanceKM()
    {

        return distance;
    }

    //Calcuate speed
    public virtual double CalculateSpeedKPH()
    {
        return speed;
    }


    //Calculate pace
    public virtual double calculatePace()
    {
        return pace;
    }
    
    public string GetSummary()
    {
        
        return ($"Date: {getDate()}, Activity: {activityType}, {getTime()} minutes, distance: {Math.Round(CalculateDistanceKM(), 2)} Km, speed: {Math.Round(CalculateSpeedKPH(), 2)} kph" +
        $" pace: {Math.Round(calculatePace(), 2)} min per km");
    }


}