namespace Geometry.Models;

public class Circle
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public virtual double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}