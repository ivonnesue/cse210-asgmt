using System;

public class Fraction
{
    //class attributes:
    private int _top;
    private int _bottom;


    //constructors to set initial state of the object Fraction
    public void fraction()
    {
        //sets default to 1/1
        _top = 1;
        _bottom = 1;
    }
    
    public void fraction (int wholeNumber)
    {
        //initializes denomitaro to 1
        _top =  wholeNumber;
        _bottom = 1;
    }

    public void fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }
    
    public int getTop()
    {
        return _top;
        
    }

    public void setTop(int fractionTop)
    {
        _top = fractionTop;

    }
    
    public int getBottom()
    {
        return _bottom;
    }

    public int setBottom(int fractionBottom)
    {
        return _bottom;
    }
    public string getFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double getDecimalValue()
    {
        double value = (double)_top / _bottom;
        return value;
    }


}