using System;

public class Rectangle : Shape
{
    private double _length, _width;

    public Rectangle(double lenght, double width, string color) : base (color)
    {
        _length = lenght;
        _width = width;

    }


    public override double getArea()
    {
        return _length * _width;
        
    }
}



