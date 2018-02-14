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
}
