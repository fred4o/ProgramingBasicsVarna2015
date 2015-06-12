using System;


namespace _06.QuadraticEcuation
{
    class QuadraticEquation
    {
        //Problem 6.	Quadratic Equation
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0
        //and solves it (prints its real roots).

        static void Main()
        {
            Console.WriteLine("Quadratic Ecuation");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter 3 numbers.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double diskriminant = (b * b) - 4 * a * c;
            double xOne = 0;
            double xTwo = 0;

            if (diskriminant < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (diskriminant > 0)
            {
                xOne = ((-b + Math.Sqrt(diskriminant)) / (2 * a));
                xTwo = ((-b - Math.Sqrt(diskriminant)) / (2 * a));
                Console.WriteLine("x1 = {0}; x2 = {1}", xOne, xTwo);
            }
            else if (diskriminant == 0)
            {
                xOne = xTwo = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", xOne);
            }
        }
    }
}
