using Measuration.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Measuration.Equations;

namespace Measuration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==> What Shape do you want to Calculate?: ");
            Console.WriteLine("Enter: \nT for Triangle \nS for Square \nR for Rectangle " +
                              "\nC for Circle \nP for Parallelogram \nTR for Trapezoid  " +
                              " \nRH for Rhombus \nSC for Semi Circle \nSP for Sphere \nCO for Cone " +
                              "\nCY for Cylinder\nPR for Rectangular Prism \nPY for Pyramid \nTP for Triangular Prism" +
                              "\nA for Angles\nQ for Quadratic Equation\nSE for Simultaneous Equation");
            string shapeChoice = Console.ReadLine();

            IShape shape = null;
            ISolid solid = null;
            IAngle angle = null;
            IEquation eqn = null;
            if (shapeChoice.ToUpper().Equals("T"))
            {
                Console.WriteLine("Please Provide the Length of the Triangle:");
                double triLenghth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Base:");
                double triBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Slant Height of the Triangle:");
                double triSlantHeight = Convert.ToDouble(Console.ReadLine());
                shape = new Triangle(triLenghth,triBase, triSlantHeight);
            }
            else if (shapeChoice.ToUpper().Equals("S"))
            {
                Console.WriteLine("Please Provide the value of the Side of the Square:");
                double squareLength = Convert.ToDouble(Console.ReadLine());
                shape = new Square(squareLength);
            }
            else if (shapeChoice.ToUpper().Equals("R"))
            {
                Console.WriteLine("Please Provide the Length of the Rectangle:");
                double recLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Rectangle:");
                double recHeight = Convert.ToDouble(Console.ReadLine());
                shape = new Rectangle(recHeight, recLength);   
            }
            else if (shapeChoice.ToUpper().Equals("C"))
            {
                Console.WriteLine("Please Provide the Radius of the Circle:");
                double circlerad = Convert.ToDouble(Console.ReadLine());
                shape = new Circle(circlerad);
            }
            else if (shapeChoice.ToUpper().Equals("TR"))
            {
                Console.WriteLine("Please Provide the Slant Height of the Trapezium:");
                double slantHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Base Height of the Trapezium:");
                double baseHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Top Height of the Trapezium:");
                double topHeight = Convert.ToDouble(Console.ReadLine());
                shape = new Trapezoid(topHeight, baseHeight, slantHeight);
            }
            else if (shapeChoice.ToUpper().Equals("P"))
            {
                Console.WriteLine("Please Provide the Slant Height of the Parallelogram:");
                double slantHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Base Length of the Parallelogram:");
                double baseLength = Convert.ToDouble(Console.ReadLine());  
                shape = new Parallelogram(slantHeight, baseLength);
            }
            else if (shapeChoice.ToUpper().Equals("RH"))
            {
                Console.WriteLine("Please Provide the value of the smaller diameter of the Rhombus:");
                double smallDiameter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value of the bigger diameter of the Rhombus:");
                double bigDiameter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value of the slant side of the Rhombus:");
                double rhombusSide = Convert.ToDouble(Console.ReadLine());
                shape = new Rhombus(smallDiameter, bigDiameter, rhombusSide);
            }
            else if (shapeChoice.ToUpper().Equals("SC"))
            {
                Console.WriteLine("Please Provide the radius of the Semi Circle:");
                double semiRadius = Convert.ToDouble(Console.ReadLine());
                shape = new SemiCircle(semiRadius);
            }
            else if (shapeChoice.ToUpper().Equals("SP"))
            {
                Console.WriteLine("Please Provide the radius of the Sphere:");
                double sphereRad = Convert.ToDouble(Console.ReadLine());
                solid = new Sphere(sphereRad);
            }
            else if (shapeChoice.ToUpper().Equals("CO"))
            {
                Console.WriteLine("Please Provide the radius of the Cone:");
                double conRad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Cone:");
                double conHeight = Convert.ToDouble(Console.ReadLine());
                solid = new Cone(conRad, conHeight);
            }
            else if (shapeChoice.ToUpper().Equals("CY"))
            {
                Console.WriteLine("Please Provide the radius of the Cylinder:");
                double cyRad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Cylinder:");
                double cyHeight = Convert.ToDouble(Console.ReadLine());
                solid = new Cylinder(cyRad, cyHeight);
            }
            else if (shapeChoice.ToUpper().Equals("PR"))
            {
                Console.WriteLine("Please Provide the length of the Rectangular Prism:");
                double prLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the width of the Rectangular Prism:");
                double prWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Rectangular Prism:");
                double prHeight = Convert.ToDouble(Console.ReadLine());
                solid = new RectangularPrism(prLength, prWidth, prHeight);
            }
            else if (shapeChoice.ToUpper().Equals("PY"))
            {
                Console.WriteLine("Please Provide the base length of the Pyramid:");
                double pyBaseLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the side length of the Pyramid:");
                double pySide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Pyramid:");
                double pyHeight = Convert.ToDouble(Console.ReadLine());
                solid = new Pyramid(pyBaseLength, pySide, pyHeight);
            }
            else if (shapeChoice.ToUpper().Equals("TP"))
            {
                Console.WriteLine("Please Provide the base length of the Triangular Prism:");
                double tripriLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the side length of the Triangular Prism:");
                double tripriSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Triangular Prism:");
                double tripriHeight = Convert.ToDouble(Console.ReadLine());
                solid = new TriangularPrism(tripriLength, tripriSide, tripriHeight);
            }
            else if (shapeChoice.ToUpper().Equals("A"))
            {
                Console.WriteLine("Please Provide the value Angle in degree:");
                double angleDegree = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value Angle in radian:");
                double angleRadian = Convert.ToDouble(Console.ReadLine());
                angle = new AngleConversion(angleRadian, angleDegree);
            }
            else if (shapeChoice.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Please Provide the value A:");
                double quadA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value B:");
                double quadB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value C:");
                double quadC = Convert.ToDouble(Console.ReadLine());
                eqn = new Quadratic(quadA, quadB,quadC);
            }
            else if (shapeChoice.ToUpper().Equals("SE"))
            {
                Console.WriteLine("Please Provide the value A:");
                double simA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value B:");
                double simB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value C:");
                double simC = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value D:");
                double simD = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value E:");
                double simE = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value F:");
                double simF = Convert.ToDouble(Console.ReadLine());
                eqn = new Simultaneous(simA, simB, simC, simD, simE, simF);
            }



            Console.WriteLine("------- RESULT -------");
            Console.WriteLine($"The Area of the selected Shape is {shape?.GetArea()}");
            Console.WriteLine($"The Perimeter of the selected Shape is {shape?.GetPerimeter()}");
            Console.WriteLine($"The Surface Area of the selected Shape is {solid?.GetSurfaceArea()}");
            Console.WriteLine($"The Volume of the selected Shape is {solid?.GetVolume()}");
            Console.WriteLine($"The Value of the angle in Degree is {angle?.GetRadianToDegree()}");
            Console.WriteLine($"The Value of the angle in Radian is {angle?.GetDegreeToRadian()}");
            Console.WriteLine($"The Values of X1 and X2 in the Equations are {eqn?.GetFirstValue()} and {eqn?.GetSecondValue()}");
        }
    }
}
