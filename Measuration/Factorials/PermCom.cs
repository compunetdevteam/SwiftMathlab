using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Measuration.Shape;

namespace Measuration.Factorials
{
    public class Factorial : IFactorial
    {

        private double _n;
        private double _factorial = 1;

        public Factorial(double n)
        {
            _n = n;

            while (_n >= 1)
            {
                _factorial = _n * _factorial;
                _n--;
            }
        }

        public double GetFactorial()
        {
            return _factorial;
        }
    }
    public class Permutation : IFactorial
    {
        private double _n;
        private double _r;
        private double _factorial = 1;
        private double _rfactor = 1;
        private double _result;


        public Permutation(double n, double r)
        {
            _n = n;
            _r = r;
            _result = (_n - _r);

            while (_n >= 1)
            {
                _factorial = _n * _factorial;
                _n--;
            }
            while (_result >= 1)
            {
                _rfactor = _result * _rfactor;
                _result--;
            }
        }

        public double GetFactorial()
        {
            return (_factorial / _rfactor);
        }
    }

    public class Combination : IFactorial
    {
        private double _n;
        private double _r;
        private double _factorial = 1;
        private double _rfactor = 1;
        private double _rdeno = 1;
        private double _result;


        public Combination(double n, double r)
        {
            _n = n;
            _r = r;
            _result = (_n - _r);

            while (_n >= 1)
            {
                _factorial = _n * _factorial;
                _n--;
            }
            while (_r >= 1)
            {
                _rdeno = _r * _rdeno;
                _r--;
            }
            while (_result >= 1)
            {
                _rfactor = _result * _rfactor;
                _result--;
            }
        }

        public double GetFactorial()
        {
            return (_factorial / (_rfactor * _rdeno));
        }
    }
}
