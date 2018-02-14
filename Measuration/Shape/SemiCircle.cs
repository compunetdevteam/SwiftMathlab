using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class SemiCircle : IShape
    {
        private double PI = Math.PI;
        private double _semiRadius;

        public SemiCircle(double semiRadius)
        {
            _semiRadius = semiRadius;
        }
        public double GetArea()
        {
            return PI*(_semiRadius * _semiRadius)/2;
        }

        public double GetPerimeter()
        {
            return (PI*(_semiRadius))+ _semiRadius*2;
        }
    }
}
