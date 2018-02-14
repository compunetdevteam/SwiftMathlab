using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Cone : ISolid
    {
        private double _coneRad;
        private double _coneheight;
        private double PI = Math.PI;

        public Cone(double coneheight, double coneRad)
        {
            _coneRad = coneRad;
            _coneheight = coneheight;

        }
        public double GetSurfaceArea()
        {
            return PI*((_coneRad * _coneRad) + Math.Sqrt((_coneRad*_coneRad)+(_coneheight*_coneheight)));
        
        }

        public double GetVolume()
        {
            return (PI * _coneRad * _coneRad * _coneheight)/3;
        }
    }
}
