using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Sphere : ISolid
    {
        private double PI = Math.PI;
        private double _sphereRad;

        public Sphere(double sphereRad)
        {
            _sphereRad = sphereRad;
        }

        public double GetSurfaceArea()
        {
            return 4 * PI * _sphereRad * _sphereRad;
        }

        public double GetVolume()
        {
            return 4/3 * _sphereRad * _sphereRad * _sphereRad;
        }

      
    }
}
