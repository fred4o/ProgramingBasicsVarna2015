using System;
using System.Numerics;



namespace _07.CalculateNfactKfactMinN
{
    class Calculate
    {

        //Problem 7. Calculate N! / (K! * (N-K)!)

        //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
        //(also known as the number of combinations) is calculated by the following formula: formula For example, 
        //there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
        //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
        static void Main()
        {
            Console.WriteLine("Calculate N! / (K! * (N-K)!)");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter two numbers ");
            int n, k;
            BigInteger sum;
            
            Console.Write("n = ");
            int.TryParse (Console.ReadLine(),out n);
            Console.Write("k = ");
            int.TryParse (Console.ReadLine(),out k);
            if (n > 1 && k > 1 && n < 100 && k < 100)
            {
                BigInteger factorielN = Factorial(n);
                BigInteger factorielK = Factorial(k);
                BigInteger factorialX = Factorial(n-k);
                sum = factorielN / (factorielK * factorialX);

                Console.WriteLine("Sum of factoriels = {0}", sum);
            }
            else
            {
                Console.WriteLine("Wrong numbers. Try again.");
            }
        }

        public static BigInteger Factorial (int input)
        {
            BigInteger factorial = 1;
            for (BigInteger i = 1; i <= input; i++)
            {
                factorial *= i;

            }
            return factorial;
        }
    }
}
