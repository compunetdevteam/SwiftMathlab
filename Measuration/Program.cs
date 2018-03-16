using Measuration.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Measuration.Equations;
using Measuration.Matrix;
using Measuration.Factorials;

namespace Measuration
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter Corresponding Key for the shape to Calculate: ");
            Console.WriteLine("\tEnter: \n\tT for \tTriangle \n\tS for \tSquare \n\tR for \tRectangle " +
                              "\n\tC for \tCircle \n\tP for \tParallelogram \n\tTR for \tTrapezoid  " +
                              " \n\tRH for \tRhombus \n\tSC for \tSemi Circle " +
                              "\n\tSP for \tSphere \n\tCO for \tCone " +
                              "\n\tCY for \tCylinder\n\tPR for \tRectangular Prism \n\tPY for \tPyramid " +
                              "\n\tTP for Triangular Prism" +
                              "\n\tDR for \tDegree To Radian\n\tRD for \tRadian To Degree" +
                              "\n\tQ for \tQuadratic Equation\n\tSE for \tSimultaneous Equation" +
                              "\n\tMT for the Determinant of 2X2 Matrix  \n\tMTT for the Determinant of 3X3 Matrix" +
                              "\n\tFA for \tFactorial \n\tPE for \tPermutation \n\tCM for \tCombination");
            var shapeChoice = Console.ReadLine();
            Console.Clear();

            IShape shape = null;
            ISolid solid = null;
            IAngle angle = null;
            IEquation eqn = null;
            IMatrix matrix = null;
            IFactorial fact = null;
            if (shapeChoice.ToUpper().Equals("T"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Triangle: ");
                sb.AppendLine("Parameters needed are: \nLength: l, \nBase: b,  \nHeight: h ");
                sb.AppendLine("Area of a Triangle: 1/2 * b * h");
                sb.AppendLine("Perimeter of a Triangle:(h+b+l)");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the Length of the Triangle:");
                double triHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Base:");
                double triBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Slant Height of the Triangle:");
                double triSlantHeight = Convert.ToDouble(Console.ReadLine());
                shape = new Triangle(triHeight, triBase, triSlantHeight);
                Console.Clear();
                Console.WriteLine("Computing for the Area \nHeight:{0}, " +
                                  "\nBase:{1}\nusing the relation: 1/2*{0}*{1} gives " +
                                  "\nArea:{2}", triHeight, triBase, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Perimeter\nHeight:{0}, " +
                                  "\nBase:{1} \nLength:{2} \nusing the relation: {0} + {1} + {2} gives " +
                                  "\nPerimeter:{3}", triSlantHeight, triBase, triHeight, shape?.GetPerimeter());
            }
            else if (shapeChoice.ToUpper().Equals("S"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Square: ");
                sb.AppendLine("Parameters needed are: Square Length, L ");
                sb.AppendLine("Area of a Square: L * L");
                sb.AppendLine("Perimeter of a Square:(4 * L)");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the value of the Side of the Square:");
                double squareLength = Convert.ToDouble(Console.ReadLine());
                shape = new Square(squareLength);

                Console.Clear();
                Console.WriteLine("Computing for the Area \nSquare Length:{0}, " +
                                  "\nusing the relation: {0}*{0} gives " +
                                  "\nArea:{1}", squareLength, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Perimeter\nSquare Length:{0}, " +
                                  "\nusing the relation: 4 * {0} gives " +
                                  "\nPerimeter:{1}", squareLength, shape?.GetPerimeter());

            }
            else if (shapeChoice.ToUpper().Equals("R"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Rectangle: ");
                sb.AppendLine("Parameters needed are: \nLength: l,\nHeight: h ");
                sb.AppendLine("Area of a Rectangle: l * h");
                sb.AppendLine("Perimeter of a Rectangle: 2 *(l + h)");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the Length of the Rectangle:");
                double recLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Rectangle:");
                double recHeight = Convert.ToDouble(Console.ReadLine());
                shape = new Rectangle(recLength, recHeight);

                Console.Clear();
                Console.WriteLine("Computing for the Area \nLength:{0},\nHeight:{1} " +
                                  "\nusing the relation: {0}*{1} gives " +
                                  "\nArea:{2}", recLength, recHeight, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Perimeter\nSquare Length:{0},\nHeight:{1} " +
                                  "\nusing the relation: 2 * ({0} +{1}) gives " +
                                  "\nPerimeter:{2}", recLength, recHeight, shape?.GetPerimeter());
            }
            else if (shapeChoice.ToUpper().Equals("C"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Circle: ");
                sb.AppendLine("Parameters needed are: \nPI: 3.142,\nRadius: r ");
                sb.AppendLine("Area of a Rectangle: PI * r * r");
                sb.AppendLine("Perimeter of a Rectangle: 2 *(PI * r)");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the Radius of the Circle:");
                double circlerad = Convert.ToDouble(Console.ReadLine());
                shape = new Circle(circlerad);

                Console.Clear();
                Console.WriteLine("Computing for the Area \nPI: 3.142,\nRadius:{0} " +
                                  "\nusing the relation: 3.142 *{0}*{0} gives " +
                                  "\nArea:{1}", circlerad, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Perimeter\nPI:3.142,\nRadius:{0} " +
                                  "\nusing the relation: 2 * 3.142 * {0} gives " +
                                  "\nPerimeter:{1}", circlerad, shape?.GetPerimeter());
            }
            else if (shapeChoice.ToUpper().Equals("TR"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Trapezium: ");
                sb.AppendLine("Parameters needed are: \nSlant Height:\nBase Height, \nTop Height");
                sb.AppendLine("Area of a Trapezium: SlantHeight*(TopHeight + BaseHeight)/2");
                sb.AppendLine("Perimeter of a Trapezium: SlantHeight + TopHeight + BaseHeight");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the Slant Height of the Trapezium:");
                double slantHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Base Height of the Trapezium:");
                double baseHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Top Height of the Trapezium:");
                double topHeight = Convert.ToDouble(Console.ReadLine());
                shape = new Trapezoid(topHeight, baseHeight, slantHeight);

                Console.Clear();
                Console.WriteLine("Computing for the Area \nSlant Height:{0},\nBase Height:{1} \nTop Height:{2} " +
                                  "\nusing the relation: {0}*[({1} + {2})/2] gives " +
                                  "\nArea:{3}", slantHeight, baseHeight, baseHeight, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(
                    "Computing for the Perimeter \nSlant Height:{0},\nBase Height:{1} \nTop Height:{2}" +
                    "\nusing the relation: {0} + {1} + {2} gives " +
                    "\nPerimeter:{3}", slantHeight, baseHeight, topHeight, shape?.GetPerimeter());
            }
            else if (shapeChoice.ToUpper().Equals("P"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Parallelogram: ");
                sb.AppendLine("Parameters needed are: \nBase Length \nSlant Height");
                sb.AppendLine("Area of a Parallelogram: baseLength * slantheight ");
                sb.AppendLine("Perimeter of a Parallelogram: 2*(baseLength + slantheight)");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the Slant Height of the Parallelogram:");
                double slantHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Base Length of the Parallelogram:");
                double baseLength = Convert.ToDouble(Console.ReadLine());
                shape = new Parallelogram(slantHeight, baseLength);

                Console.Clear();
                Console.WriteLine("Computing for the Area \nSlant Height:{0},\nBase Length:{1}" +
                                  "\nusing the relation: {0} * {1} gives " +
                                  "\nArea:{2}", slantHeight, baseLength, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Perimeter \nSlant Height:{0},\nBase Height:{1}" +
                                  "\nusing the relation: 2 *({0} + {1}) gives " +
                                  "\nPerimeter:{2}", slantHeight, baseLength, shape?.GetPerimeter());
            }
            else if (shapeChoice.ToUpper().Equals("RH"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Rhombus: ");
                sb.AppendLine("Parameters needed are: \nSmall Diameter \nBig Diameter \nRhombus Side");
                sb.AppendLine("Area of a Rhombus: (bigDiameter * smallDiameter)/2");
                sb.AppendLine("Perimeter of a Rhombus:  4 * rhombusSide");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the value of the smaller diameter of the Rhombus:");
                double smallDiameter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value of the bigger diameter of the Rhombus:");
                double bigDiameter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value of the slant side of the Rhombus:");
                double rhombusSide = Convert.ToDouble(Console.ReadLine());
                shape = new Rhombus(smallDiameter, bigDiameter, rhombusSide);

                Console.Clear();
                Console.WriteLine("Computing for the Area \nSmall Diameter:{0},\nBig Diameter :{1} \n" +
                                  "\nusing the relation: ({0} * {1})/2 gives " +
                                  "\nArea:{2}", smallDiameter, bigDiameter, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Perimeter \nRhombus Side:{0}" +
                                  "\nusing the relation: 4 *({0}) gives " +
                                  "\nPerimeter:{1}", rhombusSide, shape?.GetPerimeter());
            }
            else if (shapeChoice.ToUpper().Equals("SC"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Semi Circle: ");
                sb.AppendLine("Parameters needed are: \nPI = 3.142 \nCircle Radius");
                sb.AppendLine("Area of a Semi Circle: PI*(semiRadius * semiRadius)/2");
                sb.AppendLine("Perimeter of a Semi Circle:  (PI*(semiRadius))+ semiRadius*2");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the radius of the Semi Circle:");
                double semiRadius = Convert.ToDouble(Console.ReadLine());
                shape = new SemiCircle(semiRadius);

                Console.Clear();
                Console.WriteLine("Computing for the Area \nPI:3.142 \nRadius :{0}" +
                                  "\nusing the relation: (3.142 * {0} * {0})/2 gives " +
                                  "\nArea:{1}", semiRadius, shape?.GetArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Perimeter \nRhombus Side:{0}" +
                                  "\nusing the relation: ((3.142 *{0})+ {0} * 2) gives " +
                                  "\nPerimeter:{1}", semiRadius, shape?.GetPerimeter());
            }
            else if (shapeChoice.ToUpper().Equals("SP"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Sphere: ");
                sb.AppendLine("Parameters needed are: \nPI = 3.142 \nSphere Radius");
                sb.AppendLine("Surface Area of a Sphere: 4 * PI * sphereRad * sphereRad");
                sb.AppendLine("Volume of a Sphere:  4/3 * sphereRad * sphereRad * sphereRad");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the radius of the Sphere:");
                double sphereRad = Convert.ToDouble(Console.ReadLine());
                solid = new Sphere(sphereRad);


                Console.Clear();
                Console.WriteLine("Computing for the Surface Area \nPI:3.142 \nSphere Radius :{0}" +
                                  "\nusing the relation: 4 * (3.142 * {0} * {0}) gives " +
                                  "\nSurface Area:{1}", sphereRad, solid?.GetSurfaceArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Volume \nSphere Radius:{0}" +
                                  "\nusing the relation: (4/3 * 3.142 *{0} * {0} * {0}) gives " +
                                  "\nVolume:{1}", sphereRad, solid?.GetVolume());
            }
            else if (shapeChoice.ToUpper().Equals("CO"))
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Cone: ");
                sb.AppendLine("Parameters needed are: \nPI = 3.142 \nCone Radius");
                sb.AppendLine(
                    "Surface Area of a Cone: PI*((coneRad * coneRad) + Square Root of((coneRad*coneRad)+(coneheight*coneheight)))");
                sb.AppendLine("Volume of a Cone:  (PI * coneRad * coneRad * coneheight)/3");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the radius of the Cone:");
                double conRad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Cone:");
                double conHeight = Convert.ToDouble(Console.ReadLine());
                solid = new Cone(conRad, conHeight);

                Console.Clear();
                Console.WriteLine("Computing for the Surface Area \nPI:3.142 \nCone Radius:{0} \nCone Height:{1}" +
                                  "\nusing the relation:  3.142 *(({0} * {0}) + Square Root of(({0} * {0})+({1} * {1}))) gives " +
                                  "\nSurface Area:{2}", conRad, conHeight, solid?.GetSurfaceArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Volume \nCone Radius:{0} \nCone Height:{0}" +
                                  "\nusing the relation: (3.142 * {0} * {0} * {1})/3 gives " +
                                  "\nVolume:{2}", conRad, conHeight, solid?.GetVolume());
            }
            else if (shapeChoice.ToUpper().Equals("CY"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Cylinder: ");
                sb.AppendLine("Parameters needed are: \nPI = 3.142 \nCylinder Radius  \nCylinder Height");
                sb.AppendLine("Surface Area of a Cylinder: 2 * PI * cyRadius * (cyRadius + cyHeight)");
                sb.AppendLine("Volume of a Cylinder:  PI * cyRadius * cyRadius * cyHeight");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the radius of the Cylinder:");
                double cyRad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Cylinder:");
                double cyHeight = Convert.ToDouble(Console.ReadLine());
                solid = new Cylinder(cyRad, cyHeight);


                Console.Clear();
                Console.WriteLine(
                    "Computing for the Surface Area \nPI:3.142 \nCylinder Radius:{0} \nCylinder Height:{1}" +
                    "\nusing the relation:  2 * 3.142 * {0} * ({0} + {1}) gives " +
                    "\nSurface Area:{2}", cyRad, cyHeight, solid?.GetSurfaceArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Volume \nCylinder Radius:{0} \nCylinder Height:{1}" +
                                  "\nusing the relation: 3.142 * {0} * {0} * {1} gives " +
                                  "\nVolume:{2}", cyRad, cyHeight, solid?.GetVolume());

            }
            else if (shapeChoice.ToUpper().Equals("PR"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Rectangular Prism: ");
                sb.AppendLine("Parameters needed are: \nPrism Length \nPrism Width  \nPrism Height");
                sb.AppendLine(
                    "Surface Area of a Rectangular Prism: 2 *(priHeight * priLength + priLength * priWidth + priWidth * priHeight)");
                sb.AppendLine("Volume of a Rectangular Prism:  priWidth * priHeight * priLength");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the length of the Rectangular Prism:");
                double prLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the width of the Rectangular Prism:");
                double prWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Rectangular Prism:");
                double prHeight = Convert.ToDouble(Console.ReadLine());
                solid = new RectangularPrism(prLength, prWidth, prHeight);

                Console.Clear();
                Console.WriteLine(
                    "Computing for the Surface Area Rectangular Prism \nPrism Length:{0} \nPrism Width:{1}   \nPrism Height:{2} " +
                    "\nusing the relation:  2 *({2} * {0} + {0} * {1} + {1} * {2}) gives " +
                    "\nSurface Area:{3}", prLength, prWidth, prHeight, solid?.GetSurfaceArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(
                    "Computing for the Volume \nPrism Length:{0} \nPrism Width:{1} \nPrism Height:{2}" +
                    "\nusing the relation:  ({0} * {1} * {2}) gives " +
                    "\nVolume:{3}", prLength, prWidth, prHeight, solid?.GetVolume());
            }
            else if (shapeChoice.ToUpper().Equals("PY"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Pyramid: ");
                sb.AppendLine("Parameters needed are: \nPyramid Length \nPyramid Base Side  \nPyramid Height");
                sb.AppendLine(
                    "Surface Area of a Pyramid: 2 *(pySide * pyBaseLength) + (pyBaseLength * pyBaseLength)");
                sb.AppendLine("Volume of a Pyramid:  ((pyBaseLength * pyBaseLength) * pyHeight)/3");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the base length of the Pyramid:");
                double pyBaseLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the side length of the Pyramid:");
                double pySide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Pyramid:");
                double pyHeight = Convert.ToDouble(Console.ReadLine());
                solid = new Pyramid(pyBaseLength, pySide, pyHeight);

                Console.Clear();
                Console.WriteLine("Computing for the Surface Area \nPyramid Length:{0} \nPyramid Base Side:{1}" +
                                  "\nusing the relation:  2 * ({1} * {0}) + ({0} * {0}) gives " +
                                  "\nSurface Area:{2}", pyBaseLength, pySide, solid?.GetSurfaceArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Computing for the Volume \nPyramid Length:{0} \nPyramid Height:{1}" +
                                  "\nusing the relation: (({0} * {0}) * {1})/3) gives " +
                                  "\nVolume:{2}", pyBaseLength, pyHeight, solid?.GetVolume());
            }
            else if (shapeChoice.ToUpper().Equals("TP"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to calculate a Triangular Prism: ");
                sb.AppendLine("Parameters needed are: \nPrism Length \nPrism Side  \nPrism Height");
                sb.AppendLine(
                    "Surface Area of a Triangular Prism: (tripriHeight * tripriLength + 2 *(tripriLength * tripriSide) + tripriSide * tripriHeight)");
                sb.AppendLine("Volume of a Triangular Prism: (tripriSide * tripriHeight * tripriLength)/2");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the base length of the Triangular Prism:");
                double tripriLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the side length of the Triangular Prism:");
                double tripriSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the Height of the Triangular Prism:");
                double tripriHeight = Convert.ToDouble(Console.ReadLine());
                solid = new TriangularPrism(tripriLength, tripriSide, tripriHeight);

                Console.Clear();
                Console.WriteLine(
                    "Computing for the Surface Area Rectangular Prism \nPrism Length:{0} \nPrism Side:{1}   \nPrism Height:{2} " +
                    "\nusing the relation:  ({2} * {0} + 2 * ({0} * {1}) + {1} * {2}) gives " +
                    "\nSurface Area:{3}", tripriLength, tripriSide, tripriHeight, solid?.GetSurfaceArea());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(
                    "Computing for the Volume \nPrism Length:{0} \nPrism Side:{1} \nPrism Height:{2}" +
                    "\nusing the relation:  ({1} * {2} * {0})/2 gives " +
                    "\nVolume:{3}", tripriLength, tripriSide, tripriHeight, solid?.GetVolume());
            }
            else if (shapeChoice.ToUpper().Equals("DR"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to Convert from Degree to Radian: ");
                sb.AppendLine("Parameters needed are:  \nPI: 3.142 \nAngle in Degree");
                sb.AppendLine("Convert from Degree to Radian: (PI / 180) * degree");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the value Angle in degree:");
                double angleDegree = Convert.ToDouble(Console.ReadLine());
                angle = new DegreeToRadian(angleDegree);

                Console.Clear();
                Console.WriteLine("Computing for the Degree to Radian \nPI: 3.142 \nAngle in Degree:{0}" +
                                  "\nusing the relation:  (3.142 / 180) * {0} gives " +
                                  "\nAngle in Radian:{1}", angleDegree, angle?.GetDegreeToRadian());
            }
            else if (shapeChoice.ToUpper().Equals("RD"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to Convert from Radian to Degree: ");
                sb.AppendLine("Parameters needed are:  \nPI: 3.142 \nAngle in Radian");
                sb.AppendLine("Convert from Radian to Degree: (180 / PI) * radian");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the value Angle in radian:");
                double angleRadian = Convert.ToDouble(Console.ReadLine());
                angle = new RadianToDegree(angleRadian);

                Console.Clear();
                Console.WriteLine("Computing for the Radian to Degree \nPI: 3.142 \nAngle in Radian:{0}" +
                                  "\nusing the relation:  (180 / 3.142) * {0} gives " +
                                  "\nAngle in Radian:{1}", angleRadian, angle?.GetRadianToDegree());
            }
            else if (shapeChoice.ToUpper().Equals("Q"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to solve a quadratic equation: ");
                sb.AppendLine("Parameters needed are: \nA \nB  \nC");
                sb.AppendLine("Quadratic Equation: Ax^2 + Bx + C = 0");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Please Provide the value A:");
                double quadA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value B:");
                double quadB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Provide the value C:");
                double quadC = Convert.ToDouble(Console.ReadLine());
                eqn = new Quadratic(quadA, quadB, quadC);

                Console.Clear();
                Console.WriteLine("Computing for the quadratic equation \nA: {0} \nB:{1}  \nC:{2}" +
                                  "\nusing the relation:  {0}x^2 + {1}x + {2} = 0 gives " +
                                  "\nThe Roots Are: {3} and {4}", quadA, quadB, quadC, eqn?.GetFirstValue(),
                    eqn.GetSecondValue());
            }
            else if (shapeChoice.ToUpper().Equals("SE"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to solve a simultaneous equation: ");
                sb.AppendLine("Parameters needed are: " +
                              "\nEquation (i): \nA \nB  \nC" +
                              "\nEquation (ii): \nD \nE \nF ");
                sb.AppendLine("Equation (i): Ax + By = C\nEquation (ii): Dx + Ey = F");
                Console.WriteLine(sb.ToString());

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

                Console.Clear();
                Console.WriteLine("Computing for the simultaneous equation" +
                                  "\nEquation (i): A:{0}  B:{1}  C:{2} \nEquation (ii) D:{3}  E:{4}  F:{5}" +
                                  "\nusing the relation:  \n{0}x + {1}y = {2} .... (i) \n{3}x + {4}y = {5} .... (ii) gives " +
                                  "\nThe values of x and y are: {6} and {7} respectively.", simA, simB, simC, simD,
                    simE, simF, eqn?.GetFirstValue(), eqn.GetSecondValue());
            }
            else if (shapeChoice.ToUpper().Equals("MT"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to solve a 2x2 Matrix: ");
                sb.AppendLine("Parameters needed are: a, b, c, d");
                sb.AppendLine("a   b\nc   d");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Matrix");
                Console.WriteLine("Enter a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter d: ");
                double d = Convert.ToDouble(Console.ReadLine());
                matrix = new Matrix2(a, b, c, d);

                Console.Clear();
                Console.WriteLine("Computing for the determinant of a 2x2 matrix: \na:{0}  b:{1}  \nc:{2}  d:{3}" +
                                  "\nusing the relation: \n{0}  {1}\n{2}   {3}   \ngives " +
                                  "\nThe Determinant is: {4}", a, b, c, d, matrix?.GetDeterminant());
            }
            else if (shapeChoice.ToUpper().Equals("MTT"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want to solve a 3x3 Matrix: ");
                sb.AppendLine("Parameters needed are: a, b, c, d, e, f, g, h, i");
                sb.AppendLine("a   b  c\nd   e   f\ng   h  i");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Matrix");
                Console.WriteLine("Enter a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter d: ");
                double d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter e: ");
                double e = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter f: ");
                double f = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter g: ");
                double g = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter h: ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter i: ");
                double i = Convert.ToDouble(Console.ReadLine());
                matrix = new Matrix3(a, b, c, d, e, f, g, h, i);

                Console.Clear();
                Console.WriteLine(
                    "Computing for the determinant of a 2x2 matrix: \na:{0}  b:{1}  c:{2} \nd:{3}  e:{4} " +
                    "f:{5}\ng:{6}  h:{7}  i:{8}" +
                    "\nusing the relation: \n{0}   {1}  {2}\n{3}   {4}  {5}\n{6}   {7}  {8}  \ngives " +
                    "\nThe Determinant is: {9}", a, b, c, d, e, f, g, h, i, matrix?.GetDeterminant());
            }
            else if (shapeChoice.ToUpper().Equals("FA"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want Calculate the factorial of a number: ");
                sb.AppendLine("Parameters needed are: \nn");
                sb.AppendLine("Formular: n (n-1) (n-2) (n-3) .... (n-(n-1))");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Factorial");
                Console.WriteLine("Enter the value of n: ");
                double n = Convert.ToDouble(Console.ReadLine());
                fact = new Factorial(n);

                Console.Clear();
                Console.WriteLine(
                    "Computing for the factorial of a number: \nn:{0}!" +
                    "\nusing the relation: \n{0}*({0}-1)*({0}-2)*({0}-3)*({0}-4) .... ({0}-({0}-1))  \ngives " +
                    "\nThe Determinant is: {1}", n, fact?.GetFactorial());

            }
            else if (shapeChoice.ToUpper().Equals("PE"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want Calculate the Permutation: ");
                sb.AppendLine("Parameters needed are: \nn \nr");
                sb.AppendLine("Formular: nPr = n!/(n-r)!");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Permutation");
                Console.WriteLine("Enter the value of n: ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of r: ");
                double r = Convert.ToDouble(Console.ReadLine());
                fact = new Permutation(n, r);

                Console.Clear();
                Console.WriteLine(
                    "Computing for the Permutation: \nn:{0} \nr ={1} " +
                    "\nusing the relation: \n{0}P{1} = {0}!/({0}-{1})! \ngives " +
                    "\nThe Determinant is: {2}", n,r, fact?.GetFactorial());

            }
            else if (shapeChoice.ToUpper().Equals("CM"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("You want Calculate the Permutation: ");
                sb.AppendLine("Parameters needed are: \nn \nr");
                sb.AppendLine("Formular: nCr = n!/r!(n-r)!");
                Console.WriteLine(sb.ToString());

                Console.WriteLine("Combination");
                Console.WriteLine("Enter the value of n: ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of r: ");
                double r = Convert.ToDouble(Console.ReadLine());
                fact = new Combination(n, r);

                Console.Clear();
                Console.WriteLine(
                    "Computing for the Permutation: \nn:{0} \nr ={1} " +
                    "\nusing the relation: \n{0}C{1} = {0}!/{1}!({0}-{1})! \ngives " +
                    "\nThe Determinant is: {2}", n, r, fact?.GetFactorial());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}