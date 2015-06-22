﻿using System;
using System.Numerics;


namespace _18.TrailingZeroesInN
{

        //    Problem 18.* Trailing Zeroes in N!

        //Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
        //Your program should work well for very big numbers, e.g. n=100000.
    class TrailingZeroesInN
    {
           
        static void Main()
        {
            Console.WriteLine("Trailing zeros In N");
            Console.WriteLine("-------------------");
            Console.Write("Enter number N = ");
            int num = int.Parse(Console.ReadLine());

            int counterZeroes = 0;
            int divider = 5;
            while (num / divider >= 1)
            {
                counterZeroes += num / divider;
                divider *= 5;
            }
            Console.WriteLine("Zeroes in N! on your number {0} is = {1}", num, counterZeroes);

        }

    }
}
