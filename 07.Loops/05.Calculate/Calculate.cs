using System;


namespace _05.Calculate
{
    class Calculate
    {
        //Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        //Use only one loop. Print the result with 5 digits after the decimal point.

        static void Main()
        {
            int n, x;
            int.TryParse( Console.ReadLine(),out n);
            int.TryParse(Console.ReadLine(),out x);
            if (n<1)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                double factorialN = 1;
                double numXPowerN = 1;
                double sumOfSequence = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                    numXPowerN *= x;
                    sumOfSequence += (factorialN / numXPowerN);
                }
                Console.WriteLine("The Sum of sequence of these numbers N and X is SUM = {0:F5} !",
                    sumOfSequence);
            }

        }
    }
}
