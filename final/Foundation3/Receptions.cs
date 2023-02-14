using System;

public class Receptions : Event
{
    public string email;

    public Receptions(string _email) : base()
    {
        email = _email;
        
    }

    public string DefineAdditionalInfo()
    {
        
        additionalInfo = String.Format("RSVP: {0}", email);
        return additionalInfo;
    }
}