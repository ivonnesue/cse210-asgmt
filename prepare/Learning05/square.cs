using System;

public class Square : Shape
{
    private double _side;
    public Square(double side, string color) : base (color)
    {
        _side = side;
    }


    public override double getArea()
    {
        return Math.Pow(_side, 2);
    }
}


