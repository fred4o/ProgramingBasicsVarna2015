using System;


namespace _04.Rectangles
{
    class Rectangles
    {
//        Problem 4.	Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.

        static void Main()
        {
            double recWidth, recHeight,perimeter,area;
            string inputHeight, inputWidth;
            Console.WriteLine("Enter a rectangle width and height!!");
            Console.Write("width W = ");
            inputWidth = Console.ReadLine();
            Console.Write("height H = ");
            inputHeight = Console.ReadLine();
            if (double.TryParse(inputHeight,out recHeight)&& double.TryParse(inputWidth,out recWidth))
            {
                perimeter = (recWidth + recHeight) * 2;
                area = recWidth * recHeight;
                Console.WriteLine("Perimeter and area of your rectangle is P = {0} A = {1}",perimeter,area);
            }
            else
            {
                Console.WriteLine("Invalid input!!!!");
            }

        }
    }
}
