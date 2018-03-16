using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Rectangle : IShape
    {
        private double _recLength;
        private double _recHeight;
        public Rectangle(double recLength, double recHeight)
        {
            _recLength = recLength;
            _recHeight = recHeight;
        }
        public double GetArea()
        {
            return _recLength*_recHeight;
        }

        public double GetPerimeter()
        {
            return (_recLength + _recHeight)*2;
        }
    }

   
}
