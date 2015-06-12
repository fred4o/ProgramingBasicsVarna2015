using System;

namespace _09.Trapezoid
{
    class Trapezoid
    {
//        Problem 9.	Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

        static void Main()
        {
            double a, b, h, area;
            string inputA,inputB,inputH;
            Console.WriteLine("Enter Trapezoid Parameters:");
            Console.Write("side A = ");
            inputA = Console.ReadLine();
            Console.Write("side B = ");
            inputB = Console.ReadLine();
            Console.Write("height H = ");
            inputH = Console.ReadLine();

            if (double.TryParse(inputA,out a)&&double.TryParse(inputB,out b)&&double.TryParse(inputH,out h))
            {
                area = h * ((a + b) / 2);
                Console.WriteLine("Trapezoid Area A = {0}",area);
            }
            else
            {
                Console.WriteLine("Ivalid number!!!");
            }
        }
    }
}
