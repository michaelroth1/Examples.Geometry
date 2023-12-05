using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class AreaCalulator
    {
        public double CalculateArea(object shape)
        {           
            if (shape is Rectangle rectangle)
            {
                return rectangle.GetArea();
            }
            else if (shape is Trinagle trinagle)
            {
                return trinagle.GetArea();
            }
            else if (shape is Circle circle)
            {
                return circle.GetArea();
            }
            else
            {
                throw new ArgumentException("Shape has not the expected type");
            }
        }
    }
}