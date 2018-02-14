using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Pyramid : ISolid
    {
        private double _pyHeight;
        private double _pyBaseLength;
        private double _pySide;

        public Pyramid(double pySide, double pyHeight, double pyBaseLength)
        {
            _pyHeight = pyHeight;
            _pyBaseLength = pyBaseLength;
            _pySide = pySide;
        }
        public double GetSurfaceArea()
        {
            return 2*(_pySide *_pyBaseLength) +(_pyBaseLength * _pyBaseLength);
        }

        public double GetVolume()
        {
           return ((_pyBaseLength * _pyBaseLength) * _pyHeight)/3;
        }
    }
}
