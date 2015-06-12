using System;


namespace _09.SumOfNNums
{
    class SumOfNums
    {
        //Problem 9.	Sum of n Numbers
        //Write a program that enters a number n and after that enters more n numbers and calculates
        //and prints their sum. Note that you may need to use a for-loop.

        static void Main()
        {
            Console.Write("Enter how many numbers to sum. n =");
            double num;
            if (double.TryParse(Console.ReadLine(), out num) == false)
            {
                Console.WriteLine("Invalid Number!!!");
            }
            Console.WriteLine("Enter {0} numbers", num);
            double sum=0;
            for (int i = 1; i <= num; i++)
            {
                double number;
                if (double.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("Invalid Number. Please Try Again");
                    i--;
                }
                sum += number;
            }
            Console.WriteLine("sum of your numbers is = {0}", sum);
        }
    }
}
