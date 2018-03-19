using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Measuration.Shape;

namespace Measuration.Equations
{
    class PowerRoots : IPowerRoots
    {
        private double _number;
        private double _squareVal;
        private double _cubeVal;
        private double _squareRoot;

        public PowerRoots(double number)
        {
            _number = number;
            _squareVal = _number * _number;
            _cubeVal = _number * _number * _number;
            _squareRoot = Math.Sqrt(_number);
         
        }

     
        public double GetCubeValues()
        {
            return _cubeVal;
        }

        public double GetSquareRoots()
        {
            return _squareRoot;
        }

        public double GetSquareValue()
        {
            return _squareVal;
        }
    }
}
