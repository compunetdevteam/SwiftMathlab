using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class TriangularPrism : ISolid
    {
        private double _tripriLength;
        private double _tripriHeight;
        private double _tripriSide;

        public TriangularPrism(double tripriLength, double tripriHeight, double tripriWidth)
        {
            _tripriLength = tripriLength;
            _tripriHeight = tripriHeight;
            _tripriSide = tripriWidth;
        }
        public double GetSurfaceArea()
        {
            return (_tripriHeight * _tripriLength + 2*(_tripriLength * _tripriSide) + _tripriSide * _tripriHeight);
        }

        public double GetVolume()
        {
            return (_tripriSide * _tripriHeight * _tripriLength)/2;
        }
    }
}
