using System;

public class Lectures : Event
{
    private string speakerName;
    private int capacity = 0;

    public Lectures (string _speakerName, string _eventType, int _capacity) : base()
    {
        speakerName = _speakerName;
        capacity = _capacity;
        eventType = _eventType;
    }

    //public void setAdditionalInfo(string _additionalInfo)
    //{
    //    additionalInfo = _additionalInfo;
    //}

    public string DefineAdditionalInfo()
    {
        getAdditionInfo();
        additionalInfo = String.Format("Speaker: {0}, Seats available: \n{1}", speakerName, capacity);
        return additionalInfo;
    }
}