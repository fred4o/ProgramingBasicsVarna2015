using System;


namespace _01ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        //Problem 1. Exchange If Greater

        //Write an if-statement that takes two double variables a and b and exchanges their values if the first
        //one is greater than the second one. As a result print the values a and b, separated by a space.

        static void Main()
        {
            double firstNum, secondNum, holder;
            Console.WriteLine("Exchange If Greater");
            Console.WriteLine("-------------------");
            Console.Write("enter first number = ");
            double.TryParse(Console.ReadLine(),out firstNum);
            Console.Write("enter second number = ");
            double.TryParse(Console.ReadLine(), out secondNum);
            if (firstNum > secondNum)
            {
                holder = firstNum;
                firstNum = secondNum;
                secondNum = holder;
            }
            Console.WriteLine("{0} {1}",firstNum,secondNum);
        }
    }
}
