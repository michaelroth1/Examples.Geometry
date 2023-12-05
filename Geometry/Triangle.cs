using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trinagle
    {
        public Trinagle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public double BaseLength { get; set; }

        public double Height { get; set; }

        public double GetArea()
        {
            return BaseLength * Height / 2;
        }
    }
}