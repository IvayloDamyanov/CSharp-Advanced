using System;

namespace TriangleSurfaceBySideAndAltitude
{
    class TriangleSurfaceBySideAndAltitude
    {
        static double Area(double len, double alt)
        {
            double area = (len*alt)/2;
            return area;
        }
        static void Main()
        {
            double sideLength = double.Parse(Console.ReadLine());
            double altitutde = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", Area(sideLength, altitutde));
        }
    }
}
