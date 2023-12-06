namespace Geometry.Models;
public class Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }

    public double Height { get; set; }
}