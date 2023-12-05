namespace Geometry
{
    public class Rectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}