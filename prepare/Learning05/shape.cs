using System;

public abstract class Shape
{
    private string _color;
   // private double _area;

    public Shape(string color)
    {
        _color = color;
       // _area = area;
    }

    public string getColor()
    {
        return _color;
    }

    public void setColor(string color)
    {
        _color = color;
    }
    
    //public virtual double getArea()
    //{
    //    return 0;
    //}

    public abstract double getArea();
}