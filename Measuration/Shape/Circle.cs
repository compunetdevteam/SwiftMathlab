using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measuration.Shape
{
    public class Circle : IShape
    {
        private double PI = Math.PI;
        private double _circlerad;

        public Circle(double circlerad)
        {
            _circlerad = circlerad;
        }
        public double GetArea()
        {
            return PI*(_circlerad * _circlerad);
        }

        public double GetPerimeter()
        {
            return 2*PI*(_circlerad);
        }
    }
}
