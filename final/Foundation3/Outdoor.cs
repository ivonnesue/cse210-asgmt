using System;

public class OutdoorEvent : Event
{
    public string weather;

    public OutdoorEvent(string _weather) : base()
    {
        weather = _weather;
    
    }

    public string DefineAdditionalInfo()
    {
        
        additionalInfo = String.Format("weather: {0}", weather);
        return additionalInfo;
    }
}