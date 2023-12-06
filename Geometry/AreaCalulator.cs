using Geometry.Models;

namespace Geometry;

public class AreaCalulator
{
    public double CalculateArea(object shape)
    {
        if (shape.GetType() == typeof(Rectangle))
        {
            var rect = (Rectangle)shape;
            return rect.Width * rect.Height;
        }
        else if (shape.GetType() == typeof(Trinagle))
        {
            var trinagle = (Trinagle)shape;
            return trinagle.BaseLength * trinagle.Height / 2;
        }
        else if (shape.GetType() == typeof(Circle))
        {
            var circle = (Circle)shape;
            return Math.PI * circle.Radius * circle.Radius;
        }
        else
        {
            throw new ArgumentException("Shape has not the expected type");
        }
    }
}