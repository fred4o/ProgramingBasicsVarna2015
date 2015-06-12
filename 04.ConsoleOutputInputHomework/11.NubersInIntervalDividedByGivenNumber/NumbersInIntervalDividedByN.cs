using System;


namespace _11.NubersInIntervalDividedByGivenNumber
{
    class NumbersInIntervalDividedByN
    {
        //Numbers in Interval Dividable by Given Number
        //Write a program that reads two positive integer numbers and prints how many numbers p 
        //exist between them such that the reminder of the division by 5 is 0. 

        static void Main()
        {
            Console.WriteLine("Enter two numbers for interval");
            int firstNum;
            if (int.TryParse(Console.ReadLine(), out firstNum)==false)
            {
                Console.WriteLine("Invalid Number!!!");
                return;   
            }
            int secondNum;
            if (int.TryParse(Console.ReadLine(), out secondNum) == false)
            {
                Console.WriteLine("Invalid Number!!!");
                return; 
            }
            int nums = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    nums++;

                }
            }
            Console.WriteLine("{0} numbers between {1} and {2} is divided by 5", nums, firstNum, secondNum);
            Console.WriteLine();
        }
       
    }
}
