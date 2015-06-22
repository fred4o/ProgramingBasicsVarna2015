using System;
using System.Numerics;


namespace _08.CatalanNumbers
{
    class CatlanNmbers
    {
        //Problem 8. Catalan Numbers

        //In combinatorics, the Catalan numbers are calculated by the following formula:(2*n)!/((n+1)!*n!)
        //Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
        public static BigInteger Factorial(int input)
        {
            BigInteger factorial = 1;
            for (BigInteger i = 1; i <= input; i++)
            {
                factorial *= i;

            }
            return factorial;
        }
        static void Main()
        {
            
            Console.WriteLine("Catalan Numbers Calculator");
            Console.WriteLine("--------------------------");
            Console.Write("Enter a number (1-100) n = ");

            //formula for Catalan Number (2*n)!/((n+1)!*n!)
            int num;
            int.TryParse(Console.ReadLine(),out num);
            if (1 < num && num < 100)
            {
                BigInteger factorielUp = Factorial(2 * num);
                BigInteger factorielDown = Factorial(num + 1) * Factorial(num);
                BigInteger sum = factorielUp / factorielDown;
                Console.WriteLine("Catalan ({0}) = {1}", num, sum);
            }
            else
            {
                Console.WriteLine("Out of Range. PLease Try Again");
            }
          



        }
    }
}
