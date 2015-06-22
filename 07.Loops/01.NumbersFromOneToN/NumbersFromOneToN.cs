using System;


namespace _01.NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        //Problem 1. Numbers from 1 to N

        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
        static void Main()
        {
            Console.WriteLine("Enter end number");
            int num;
            int.TryParse(Console.ReadLine(),out num);
            for (int i = 1; i <= num; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
    }
}
