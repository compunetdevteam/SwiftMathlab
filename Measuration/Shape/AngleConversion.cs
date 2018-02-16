using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class AngleConversion : IAngle
    {
        private double _degree;
        private double _radian;

        public AngleConversion(double degree, double radian)
        {
            _degree = degree;
            _radian = radian;
        }
        public double GetDegreeToRadian()
        {
           return (Math.PI / 180) * _degree;
        }

        public double GetRadianToDegree()
        {
            return (180 / Math.PI) * _radian;
        }
    }
}
