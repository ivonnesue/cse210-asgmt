using System;

public class Lectures : Event
{
    private string speakerName;
    private int capacity = 0;

    public Lectures (string _speakerName, int _capacity) : base()
    {
        speakerName = _speakerName;
        capacity = _capacity;
    
    }


    public string DefineAdditionalInfo()
    {
       
        additionalInfo = String.Format("Speaker: {0}, Seats available: {1}", speakerName, capacity);
        return additionalInfo;
    }
}