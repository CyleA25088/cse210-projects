namespace CircleApp;

public class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        if (_radius < 0)
            return;
            
        _radius = radius;
    }

    public void GetCircleArea()
    {
        return 3.1415 * _radius * _radius;
    }
}
