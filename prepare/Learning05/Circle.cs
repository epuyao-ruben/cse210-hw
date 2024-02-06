using System;
public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}