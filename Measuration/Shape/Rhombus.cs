using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Rhombus : IShape
    {
        private double _bigDiameter;
        private double _smallDiameter;
        private double _rhombusSide;

        public Rhombus(double bigDiameter, double smallDiameter, double rhombusSide)
        {
            _bigDiameter = bigDiameter;
            _smallDiameter = smallDiameter;
            _rhombusSide = rhombusSide;

        }
        public double GetArea()
        {
            return (_bigDiameter * _smallDiameter)/2;
        }

        public double GetPerimeter()
        {
            return 4*_rhombusSide;
        }
    }
}
