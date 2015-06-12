using System;


namespace _12.CompairingsFloats
{
    class CompairingFolats
    {
       /*
      Problem 13. Comparing Floats
        Write a program that safely compares floating-point numbers(double) with precision eps = 0.000001. 
        Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic.
        Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:
        */

        static void Main()
        {
            Console.WriteLine("Please enter First Num:");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Second Num to Compare:");
            decimal secondNum = decimal.Parse(Console.ReadLine());

            bool compares = Math.Abs(firstNum - secondNum) < 0.000001M;
            Console.WriteLine(compares);
        }
    }
}
