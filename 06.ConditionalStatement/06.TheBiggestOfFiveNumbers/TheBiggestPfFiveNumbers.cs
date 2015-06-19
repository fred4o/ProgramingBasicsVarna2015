using System;


namespace _06.TheBiggestOfFiveNumbers
{
    class TheBiggestPfFiveNumbers
    {
        static void Main()
        {

            //Problem 6. The Biggest of Five Numbers

            //Write a program that finds the biggest of five numbers by using only five if statements.


            Console.WriteLine("the Biggest of 5 numbers ");
            Console.WriteLine("-------------------");
            double firstNum , secondNum, thirdNum , fourthNum,fifthNum;
            Console.WriteLine("Enter 3 real numbers");
            Console.Write("a = ");
            firstNum = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            secondNum = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            thirdNum = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            fourthNum = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            fifthNum = double.Parse(Console.ReadLine());

            double max = firstNum;
            if (firstNum == secondNum && secondNum == thirdNum && thirdNum == fourthNum && fourthNum == fifthNum)
            {
                Console.WriteLine("five numbers are equal");
            }
            else
            {
                if (firstNum < secondNum)
                {
                    max = secondNum;
                }
                if (max < thirdNum)
                {
                    max = thirdNum;
                }
                if (max < fourthNum)
                {
                    max = fourthNum;
                }
                if (max < fifthNum)
                {
                    max = fourthNum;
                }
                Console.WriteLine(max);
            }
        }
    }
}
