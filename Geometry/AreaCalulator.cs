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
            if (shape.GetType() == typeof(Rectangle))
            {
                return ((Rectangle)shape).GetArea();
            }
            else if (shape.GetType() == typeof(Trinagle))
            {
                return ((Trinagle)shape).GetArea();
            }
            else if (shape.GetType() == typeof(Circle))
            {
                return ((Circle)shape).GetArea();
            }
            else
            {
                throw new ArgumentException("Shape has not the expected type");
            }
        }
    }
}