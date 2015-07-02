using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimesInGivenRange
{
    class PrimeInGivenRange
    {
        //Problem 3.	Primes in Given Range
        //Write a method that calculates all prime numbers in given range and returns them as list of integers:
        //static List<int> FindPrimesInRange(startNum, endNum)
        //{
        //    …
        //}
        //Write a method to print a list of integers.
        //Write a program that enters two integer numbers (each at a separate line) and prints all primes in 
        //their range, separated by a comma.

        static void Main()
        {
            int firstNum, secondNum;
            int.TryParse(Console.ReadLine(), out firstNum);
            int.TryParse(Console.ReadLine(), out secondNum);
            List<int> primeList = FindPrimeInRange(firstNum, secondNum);
            PrintPrimeNums(primeList);

        }
        static void PrintPrimeNums(List<int> inputList)
        {
            for (int i = 0; i < inputList.Count(); i++)
            {
                Console.Write("{0}, ",inputList[i]);
            }
        }
        static List<int> FindPrimeInRange(int startNum,int secondNum)
        {
            List<int> primesList = new List<int>();
            for (int i = startNum; i < secondNum; i++)
            {
                if (IsNumPrime(i))
                {
                    primesList.Add(i);
                }
            }
            return primesList;
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
