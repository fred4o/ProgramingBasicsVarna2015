using System;


namespace _06.CalculateNfactKfact
{
    class Calcuate
    {
        //Problem 6. Calculate N! / K!

        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        //Use only one loop.
        static void Main()
        {
            Console.WriteLine("Calculate N! / K!");
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter two integer");
            int n, k;
            double factoriel = 1;
            double sum = 1;

            Console.Write("n = ");
            int.TryParse(Console.ReadLine(),out n);
            Console.Write("k = ");
            int.TryParse(Console.ReadLine(),out k);
            if (n>1 && k >1 && n<100 && k<100)
            {
                factoriel = TakeFactoriel(n);
                sum = factoriel;
                factoriel = TakeFactoriel(k);
                sum = sum / factoriel;

                Console.WriteLine("Sum of factoriels = {0}",sum);
            }
            else
            { 
                Console.WriteLine("Out of range. Try again.");
            }
        }

        private static double TakeFactoriel(int n)
        {
            double factoriel =1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
