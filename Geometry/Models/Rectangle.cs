namespace Geometry.Models;

public class Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public virtual double Width { get; set; }

    public virtual double Height { get; set; }
                
    public double CalculateArea()
    {
        return Width * Height;
    }
}