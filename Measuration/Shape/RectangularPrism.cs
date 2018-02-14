using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class RectangularPrism : ISolid
    {
        private double _priLength;
        private double _priHeight;
        private double _priWidth;

        public RectangularPrism(double priLength, double priHeight, double priWidth)
        {
            _priLength = priLength;
            _priHeight = priHeight;
            _priWidth = priWidth;
        }
        public double GetSurfaceArea()
        {
           return 2*(_priHeight*_priLength + _priLength*_priWidth + _priWidth*_priHeight);
        }

        public double GetVolume()
        {
            return _priWidth*_priHeight*_priLength;
        }
    }
}
