using System;


namespace _02.PrimeChecker
{
    class PrimeCheck
    {

        //Problem 2.	Prime Checker
        //Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 

        static void Main()
        {
            int num;
            int.TryParse( Console.ReadLine() ,out num );
            bool isPrime =IsNumPrime(num);
            Console.WriteLine(isPrime);
        }
        static bool IsNumPrime(int input)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(input));

            if (input == 1) return false;
            if (input == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (input % i == 0) return false;
            }

            return true;
        }
    }
}
