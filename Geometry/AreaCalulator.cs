using Geometry.Models;

namespace Geometry;

public class AreaCalulator
{
    public double CalculateArea(object shape)
    {
        if (shape.GetType() == typeof(Rectangle))
        {
            return ((Rectangle)shape).CalculateArea();
        }
        else if (shape.GetType() == typeof(Trinagle))
        {
            return ((Trinagle)shape).CalculateArea();
        }
        else if (shape.GetType() == typeof(Circle))
        {
            return ((Circle)shape).CalculateArea();
        }
        else
        {
            throw new ArgumentException("Shape has not the expected type");
        }
    }
}