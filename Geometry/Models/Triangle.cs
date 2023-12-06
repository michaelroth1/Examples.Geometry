namespace Geometry.Models;
public class Trinagle
{
    public Trinagle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public double BaseLength { get; set; }

    public double Height { get; set; }
}