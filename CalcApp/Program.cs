using Geometry;
using Geometry.Models;

namespace CalcApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine($"Start the calculation of a rectangle:");

        AreaCalulator calculator = new();
        Rectangle rectangle = new(2, 4);

        Console.WriteLine($"The rectangle's width, height is 2, 4.");
        var area = calculator.CalculateArea(rectangle);
        Console.WriteLine($"The rectangle's area is {area}.");

        Console.WriteLine("");
        Console.WriteLine($"Changing the rectangle's width, height to 3, 5.");

        rectangle.Width = 3;
        rectangle.Height = 5;
        area = calculator.CalculateArea(rectangle);
        Console.WriteLine($"The rectangle's area is now {area}.");

        Console.ReadLine();
    }
}