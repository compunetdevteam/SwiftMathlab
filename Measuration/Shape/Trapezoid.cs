using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Trapezoid : IShape
    {
        private double _baseHeight;
        private double _slantHeight;
        private double _topHeight;

        public Trapezoid(double baseHeight, double slantHeight, double topHeight)
        {
            _baseHeight = baseHeight;
            _slantHeight = slantHeight;
            _topHeight = topHeight;

        }
        public double GetArea()
        {
            return (_slantHeight*(_topHeight + _baseHeight)/2);
        }

        public double GetPerimeter()
        {
            return _slantHeight + _topHeight + _baseHeight;
        }
    }
}
