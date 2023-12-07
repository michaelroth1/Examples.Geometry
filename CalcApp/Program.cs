using Geometry;
using Geometry.Models;

namespace CalcApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine($"Start the calculation of a rectangle's area.");

        AreaCalulator calculator = new();
        Rectangle rectangle = new(2, 4);

        Console.WriteLine($"The rectangle's width, height is {rectangle.Width}, {rectangle.Height}.");

        var area = calculator.CalculateArea(rectangle);
        Console.WriteLine($"The rectangle's area is {area}.");

        Console.ReadLine();
    }
}