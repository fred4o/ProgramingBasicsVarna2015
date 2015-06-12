using System;


namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
//        Problem 8.	Prime Number Check
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
//    (i.e. it is divisible without remainder only to itself and 1). 

        static void Main()
        {
            uint number;
            bool isPrime = true;
            Console.Write("Enter a positive integer number N = ");
            if (uint.TryParse(Console.ReadLine(),out number))
            {
                double sqrtNum = Math.Sqrt(number);
                if (number<=1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= sqrtNum; i++)
                    {
                        if (number%i==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                Console.WriteLine("The number {0} is it prime? {1}",number,isPrime);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
