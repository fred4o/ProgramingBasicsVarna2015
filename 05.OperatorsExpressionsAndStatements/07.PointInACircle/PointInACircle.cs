using System;


namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double x, y;
            string inputX, inputY;
            bool isInsideCircle;
            Console.WriteLine("Enter a poit X");
            inputX = Console.ReadLine();
            Console.WriteLine("Enter a poitn Y");
            inputY = Console.ReadLine();
            if (double.TryParse(inputX, out x) && double.TryParse(inputY, out y))
            {
                isInsideCircle = (x - 0) * (x - 0) + (y - 0) * (y - 0) < 2 * 2 ? true : false;
                Console.WriteLine("The point with x = {0} and y = {1} is inside circle? \nThe answer is: {2}", x, y, isInsideCircle);
            }
            else
            {
                Console.WriteLine("Invalid Number!!!");
            }
        }
    }
}
