using System;

namespace _03.CirclePerimeterArea
{
    class CirclePerimeterArea
    {

        //Problem 3.	Circle Perimeter and Area
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted
        //with 2 digits after the decimal point.

        static void Main()
        {
            Console.WriteLine("Enter radius of Circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double perimeter;
            double area;

            perimeter = 2 * (Math.PI * radius);
            area = Math.PI * (radius * radius);

            Console.WriteLine("Circle whith radius R = {0} have perimeter P = {1}, and area A = {2}",radius,perimeter, area);

        }
    }
}
