using System;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static double Area(double a, double b, double angAB)
            {
            double area = (a*b*Math.Sin(angAB * Math.PI / 180)) / 2;
            return area;
            }
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angleAB = double.Parse(Console.ReadLine());
            double area = Area(sideA, sideB, angleAB);
            Console.WriteLine("{0:0.00}", area);
        }
    }
}
