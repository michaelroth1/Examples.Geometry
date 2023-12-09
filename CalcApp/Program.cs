using Geometry;
using Geometry.Models;

namespace CalcApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine($"Start:");

        Rectangle rectangle = new(2, 4);
        CalculateRectangle(rectangle);

        Console.ReadLine();
    }

    private static void CalculateRectangle(Rectangle rectangle)
    {
        Console.WriteLine($"The {nameof(rectangle)}'s width, height is {rectangle.Width}, {rectangle.Height}.");

        AreaCalulator calculator = new();
        var area = calculator.CalculateArea(rectangle);

        Console.WriteLine($"The {nameof(rectangle)}'s area is {area}.");
    }
}