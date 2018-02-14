using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Cylinder : ISolid
    {
        private double _cyRadius;
        private double _cyHeight;
        private double PI = Math.PI;

        public Cylinder(double cyHeight, double cyRadius)
        {
            _cyRadius = cyRadius;
            _cyHeight = cyHeight;

        }
        public double GetSurfaceArea()
        {
            return 2* PI * _cyRadius * (_cyRadius + _cyHeight);
        }

        public double GetVolume()
        {
            return PI * _cyRadius * _cyRadius * _cyHeight;
        }
    }
}
