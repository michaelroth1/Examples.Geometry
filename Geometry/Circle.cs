namespace Geometry
{
    public class Circle
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}