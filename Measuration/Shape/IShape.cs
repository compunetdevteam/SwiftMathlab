namespace Measuration.Shape
{
    public interface IShape
    {
        double GetArea();

        double GetPerimeter();
    }

    public interface ISolid
    {
        double GetSurfaceArea();

        double GetVolume();
    }

    public interface IAngle
    {
        double GetDegreeToRadian();

        double GetRadianToDegree();
    }

    public interface IEquation
    {
        double GetFirstValue();

        double GetSecondValue();
    }
    public interface IMatrix
    {
        double GetDeterminant();
    }
    public interface IFactorial
    {
        double GetFactorial();
    }

}
