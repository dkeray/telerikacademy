using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleSurface
{
    static double SurfaceTriangle1(double side, double altitude)
    {
        double surface = 0;
        surface = (side + altitude) / 2;
        return surface;
    }

    static double SurfaceTriangle2(double side1, double side2, double angle)
    {
        double surface = 0;
        surface = side1 * side2 * Math.Sin(Math.PI*angle / 180 ) / 2;

        return surface;
    }

    static double SurfaceTriangle3(double side1, double side2, double side3)
    {
        double surface = 0;
        surface = (side1 + side2 + side3) / 2;
        return surface;
    }

    static void Main()
    {
        System.Console.WriteLine(SurfaceTriangle1(3,5));
        System.Console.WriteLine(SurfaceTriangle2(3, 5, 34));
        System.Console.WriteLine(SurfaceTriangle3(3, 4,2));
    }
}
