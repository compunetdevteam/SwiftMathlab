using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Parallelogram : IShape
    {
        private double _baseLength;
        private double _slantheight;

        public Parallelogram(double baseLength, double slantheight)
        {
            _baseLength = baseLength;
            _slantheight = slantheight;
        }
        public double GetArea()
        {
            return _baseLength * _slantheight;
        }

        public double GetPerimeter()
        {
           return 2*(_baseLength + _slantheight);
        }
    }
}
