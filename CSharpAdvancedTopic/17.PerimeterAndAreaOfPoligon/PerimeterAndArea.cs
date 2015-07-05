using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PerimeterAndAreaOfPoligon
{
    class PerimeterAndArea
    {
        //Problem 17.Perimeter and Area of Polygon
        //Write a program that calculates the perimeter and the area of given polygon (not necessarily convex)
        //consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal
        //digits after the decimal point. Use the input and output format from the examples. To hold the points,
        //define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of points.
        //Find in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon. 

        static void Main()
        {
            int pointsCount = int.Parse(Console.ReadLine());
            Polygon polygon = InitializePoligon(pointsCount);
            double polygonPerimeter, poligonArea;
            polygonPerimeter = PerimeterOfPolygon(polygon);
            poligonArea = AreaOfPolygon(polygon);

            Console.WriteLine("perimeter = {0:F2}", polygonPerimeter);
            Console.WriteLine("area = {0:F2}", poligonArea);
           
        }
        private static Polygon InitializePoligon(int n)
        {
            Polygon polygon = new Polygon();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] pointCoord = input.Split();
                Point point = new Point(double.Parse(pointCoord[0]), double.Parse(pointCoord[1]));
                polygon.Points.Add(point);
            }
            return polygon;
        }
        private static double PerimeterOfPolygon(Polygon polygon)
        {
            double perimer = 0;
            for (int i = 0; i < polygon.Points.Count; i++)
            {
                double x1 = polygon.Points[i % polygon.Points.Count].X;
                double x2 = polygon.Points[(i + 1) % polygon.Points.Count].X;
                double distanceX = (x1 - x2);
                double y1 = polygon.Points[i % polygon.Points.Count].Y;
                double y2 = polygon.Points[(i + 1) % polygon.Points.Count].Y;
                double distanceY = (y1 - y2);

                perimer += Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
            }
            return perimer;
        }

        private static double AreaOfPolygon(Polygon polygon)
        {
            double area = 0;
            for (int i = 0; i < polygon.Points.Count - 1; i++)
            {
                area += (polygon.Points[i].X * polygon.Points[i + 1].Y) - (polygon.Points[i].Y * polygon.Points[i + 1].X);
            }
            area = Math.Abs(area / 2);
            return area;
        }


    }
}
