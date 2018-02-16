using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Measuration.Shape;

namespace Measuration.Equations
{
    public class Quadratic : IEquation
    {
        private double _quadA;
        private double _quadB;
        private double _quadC;
        private double insideSquareRoot;

        public Quadratic(double quadA, double quadB, double quadC)
        {
            //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a
            _quadA = quadA;
            _quadB = quadB;
            _quadC = quadC;
            insideSquareRoot = Math.Sqrt((_quadB * _quadB) - 4 * _quadA * _quadC);

        }
        public double GetFirstValue()
        {

            if (insideSquareRoot < 0)
            {
                return double.NaN; 
            } 
            else 
            {
                return (-_quadB + insideSquareRoot) / (2 * _quadA);
            }
        }

        public double GetSecondValue()
        {
            if (insideSquareRoot < 0)
            {
                return double.NaN;
            }
            else
            {
                return (-_quadB - insideSquareRoot) / (2 * _quadA);
            }
        }
    }
}
