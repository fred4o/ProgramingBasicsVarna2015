using System;


namespace _07.SumOfFiveNums
{
    class SumOfFIve
    {
        //Problem 7.	Sum of 5 Numbers
        //Write a program that enters 5 numbers (given in a single line, separated by a space),
        //calculates and prints their sum.

        static void Main()
        {
            Console.WriteLine("Sum Of Five Numbers");

            Console.WriteLine("Enter five numbers in single line:");

            string[] input = Console.ReadLine().Split();
            double num = 0;
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (double.TryParse(input[i],out num)==false)
                {
                    Console.WriteLine("Not a valid number in line!!!!! Try Again!");
                    input = Console.ReadLine().Split();
                    i=0;
                }
                sum = sum + num;
            }
            Console.WriteLine("Sum of your numbers is = {0}", sum);
        }
    }
}
