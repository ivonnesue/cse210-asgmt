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
        //return String.Format("{0}, {1} {2} ({3} min) - Distance {4} km," +
        //" Speed {5} kph, Pace{6} min per km", date, activityType, timeInMins, distance, speed, pace);
        return ($"Date: {getDate()}, Activity: {activityType}, {getTime()} minutes, distance: {CalculateDistanceKM()} Km, speed: {CalculateSpeedKPH()} kph" +
        $" pace: {calculatePace()} min per km");
    }


}