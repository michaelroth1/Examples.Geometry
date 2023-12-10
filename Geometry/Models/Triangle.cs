namespace Geometry.Models;

public class Triangle
{
    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public virtual double BaseLength { get; set; }

    public virtual double Height { get; set; }

    public virtual double CalculateArea()
    {
        return BaseLength * Height / 2;
    }
}