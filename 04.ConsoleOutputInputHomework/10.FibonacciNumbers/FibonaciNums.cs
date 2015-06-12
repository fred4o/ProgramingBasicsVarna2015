using System;
using System.Numerics;


namespace _10.FibonacciNumbers
{
    class FibonaciNums
    {
        //Problem 10.	Fibonacci Numbers
        //Write a program that reads a number n and prints on the console the first n members of
        //the Fibonacci sequence (at a single line, separated by spaces) :
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
        //Note that you may need to learn how to use loops

        static void Main()
        {
            Console.WriteLine("Enter number for fibonacci sequence");
            int num;
            if (int.TryParse(Console.ReadLine(), out num)==false)
            {
                Console.WriteLine("Invalid Number!!!");
                return;
            }
            BigInteger fibonacciMemberX = 0;
            BigInteger fibonacciMemberOne = 0;
            BigInteger fibonacciMemberTwo = 1;

            Console.Write("{0} ", fibonacciMemberOne);
            Console.Write("{0} ", fibonacciMemberTwo);


            for (int i = 3; i <= num; i++)
            {
                fibonacciMemberX = fibonacciMemberOne + fibonacciMemberTwo;
                Console.Write("{0} ", fibonacciMemberX);

                fibonacciMemberOne = fibonacciMemberTwo;
                fibonacciMemberTwo = fibonacciMemberX;

            }
            Console.WriteLine();
        }
    }
}
