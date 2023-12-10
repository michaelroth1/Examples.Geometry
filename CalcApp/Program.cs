using Geometry;
using Geometry.Models;

namespace CalcApp;

internal class Program
{
    static void Main()
    {
        Rectangle rectangle = new(2, 4);
        CalculateRectangle(rectangle);
    }

    private static void CalculateRectangle(Rectangle rectangle)
    {
        Console.WriteLine($"Calculating the area of a {rectangle.GetType().Name}:");
        Console.WriteLine($"The {rectangle.GetType().Name}'s "
           + $"width, height is {rectangle.Width}, {rectangle.Height}.");

        var area = (new AreaCalculator()).CalculateArea(rectangle);

        Console.WriteLine($"The {rectangle.GetType().Name}'s area is {area}.{Environment.NewLine}");
    }
}