using System;

namespace CircleApp;

public class Circle
{
    private double _radious;
    
    public Circle()
    {
        _radious = 0;
    }
    
    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            _radious = 0;
            return;
        }


        _radious = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radious * _radious;
    }

    public double GetCircumference()
    {
        return _radious * 2 * Math.PI;
    }

    public double GetDiameter()
    {
        return _radious * 2;
    }
    
}
