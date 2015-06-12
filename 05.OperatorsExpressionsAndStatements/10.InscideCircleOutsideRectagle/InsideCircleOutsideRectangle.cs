using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.InscideCircleOutsideRectagle
{
    class InsideCircleOutsideRectangle
    {
        
//         Problem 10.	Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2). 

        static void Main()
        {
            double x, y;
            string inputX, inputY;
            bool isInsideCircle, isOutsideRectangle;
            Console.WriteLine("Enter coordinate of point:");
            Console.Write("X = ");
            inputX = Console.ReadLine();
            Console.Write("Y = ");
            inputY = Console.ReadLine();
            if (double.TryParse(inputX,out x)&&double.TryParse(inputY,out y))
            {
                 isInsideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) < 1.5 * 1.5 ? true : false;
                 isOutsideRectangle = (y > 1 || y < (-1)) || (y > (1 + 2) || y > (-1 + 6)) ? true : false;
                Console.WriteLine("The point with x = {0} and y = {1} is inside circle and outside rectangle?\n {2}", x, y, isInsideCircle&&isOutsideRectangle);
            }
            else
            {
                Console.WriteLine("Invalid Coordinates!!!");
            }
        }
    }
}
