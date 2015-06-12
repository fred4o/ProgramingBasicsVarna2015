using System;

namespace _08.SquareRoot
{
    class SquareRoot
    {
        /*
        Problem 8.	Square Root
        Create a console application that calculates and prints the square root of the number 12345. Find in Internet “how to calculate square root in C#”.
        */
        static void Main()
        {
            int num = 12345;
            Console.WriteLine("Square root of {0}, is {1}",num,Math.Sqrt(num));
        }
    }
}
