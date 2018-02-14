
namespace Measuration.Shape
{
    public class Triangle : IShape
    {
        private double _triHeight;
        private  double _triBase;
        private double _triSlantHeight;

        public Triangle(double triHeight, double triBase, double triSlantHeight)
        {
            _triHeight = triHeight;
            _triBase = triBase;
            _triSlantHeight = triSlantHeight;
        }

        public double GetArea()
        {
            return 0.5*(_triHeight*_triBase);
        }

        public double GetPerimeter()
        {
           return _triHeight+_triBase+_triSlantHeight;
        }
    }
}
