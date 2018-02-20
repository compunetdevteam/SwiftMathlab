using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Measuration.Shape;

namespace Measuration.Matrix
{
    public class Matrix2 : IMatrix
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;
        private double _determinant;

        public Matrix2(double a, double b, double c, double d)
        {

            //(a b)
            //     //
            //(c d)

            _a = a;
            _b = b;
            _c = c;
            _d = d;

            _determinant = (_a * _d - _b * _c);

        }

        public double GetDeterminant()
        {
            return _determinant;
        }

    }

    public class Matrix3 : IMatrix
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;
        private double _e;
        private double _f;
        private double _g;
        private double _h;
        private double _i;
        private double _determinant;

        public Matrix3(double a, double b, double c, double d, double e, double f, double g, double h, double i)
        {

            //(a b c)
            //(d e f)//
            //(g h i)

            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _e = e;
            _f = f;
            _g = g;
            _h = h;
            _i = i;
            _determinant = (_a * (_e * _i - _h * _f) - _b * (_d * _i - _g * _f) + _c * (_d * _h - _e * _g));

        }

        public double GetDeterminant()
        {
            return _determinant;
        }
    }
}
