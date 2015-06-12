using System;


namespace _01.SumOfThreeNum
{
    class SumOfThreeNums
    {
        //Problem 1.	Sum of 3 Numbers
        //Write a program that reads 3 real numbers from the console and prints their sum.

        static void Main()
        {
            int numsCount = 3;
            double[] nums = new double [numsCount];
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               Console.WriteLine("Enter {0} number", i+1);
               nums[i] = double.Parse( Console.ReadLine());
               sum += nums[i];
            }
            Console.WriteLine("Sum of theese numbers is equal = {0}",sum);

        }
    }
}
