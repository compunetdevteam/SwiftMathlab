using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Square : IShape
    {
        private double _squareLength;

        public Square(double squareLength)
        {
            _squareLength = squareLength;
        }
        public double GetArea()
        {
            return _squareLength*_squareLength;
        }

        public double GetPerimeter()
        {
            return 4*(_squareLength);
        }
    }
}
