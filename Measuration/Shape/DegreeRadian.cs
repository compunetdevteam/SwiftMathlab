using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class RadianToDegree : IAngle
    {
        
        private double _radian;

        public RadianToDegree(double radian)
        {
            _radian = radian;
        }

        public double GetDegreeToRadian()
        {
            return 0;
        }

        public double GetRadianToDegree()
        {
            return (180 / Math.PI) * _radian;
           
        }
    }

    public class DegreeToRadian : IAngle
    {
        private double _degree;

        public DegreeToRadian(double degree)
        {
            _degree = degree;
        }
        public double GetDegreeToRadian()
        {
            return (Math.PI / 180) * _degree; ;
        }

        public double GetRadianToDegree()
        {
            return 0;
        }
    }
}
