using System;

public class Event
{
    protected string eventTitle, description, date, additionalInfo, time, address, eventType;

    private string standardMessage, fullDetails, shortMessage;
    

    public void setEventTitle(string _eventTitle)
    {
        eventTitle = _eventTitle;
    }
   
    public void setDescription(string _description)
    {
        description = _description;
    }

    public void setEventDate(string _date)
    {
        date = _date;
    }

    public void setWeather(string _additionalInfo)
    {
        additionalInfo = _additionalInfo;
    }

    public void setTime(string _time)
    {
        time = _time;
    }

    public void setAddress(string _address)
    {
        address = _address;
    }

    public void setEventType(string _eventType)
    {
        eventType = _eventType;
    }
    public string FormatStandardMessage()
    {
        standardMessage = String.Format("{0} \n{1} \n{2}, {3} \n{4}", eventTitle, description, date, time, address);
        return standardMessage;
    }

    public void setAdditionInfo(string _additionalInfo)
    {
        additionalInfo = _additionalInfo;
    }
    
    public string getAdditionInfo()
    {
        return additionalInfo;
    }
    public string FormatFullDetails()
    {
        
        
        fullDetails = String.Format("{0} \n{1} \n{2}, {3}, \n {4} \n{5}", eventTitle, description, date, time, additionalInfo, address);
        return fullDetails;
    }

    public string FormatShortMessage()
    {
        shortMessage = String.Format("{0}, {1}, {2}", eventType, eventTitle, date);
        return shortMessage;
    }

     public void DisplayMessages()
    {
        Console.WriteLine(FormatStandardMessage());
        Console.WriteLine();

        Console.WriteLine(FormatFullDetails());
        Console.WriteLine();

        Console.WriteLine(FormatShortMessage());
        Console.WriteLine();
    }


}

