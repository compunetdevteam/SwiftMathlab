using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Measuration.Shape;

namespace Measuration.Equations
{
    public class Simultaneous : IEquation
    {
        private double _A;
        private double _B;
        private double _C;
        private double _D;
        private double _E;
        private double _F;
        private double numeratory;
        private double denominatory;

        public Simultaneous(double simA, double simB, double simC, double simD, double simE, double simF)
        {
            // Ax+By=C .......(1)
            // Dx+Ey=F ........(2)

            _A = simA;
            _B = simB;
            _C = simC;
            _D = simD;
            _E = simE;
            _F = simF;
            numeratory = _A * _F - _D * _C;
            denominatory = _A * _E - _D * _B;
        }
        public double GetFirstValue()
        {
            return (_C -_B*(numeratory/denominatory))/_A;
        }

        public double GetSecondValue()
        {
            return numeratory/ denominatory;
        }
    }
}
