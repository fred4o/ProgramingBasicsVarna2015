using System;


namespace _17.Calculate_GCD
{
    class CalculateGCD
    {
        //Problem 17.* Calculate GCD

        //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
        //Use the Euclidean algorithm (find it in Internet).
        static void Main()
        {
            Console.WriteLine("Calculate GCD");
            Console.WriteLine("-------------");
            Console.WriteLine("Enter two numbers");
            int a, b, divider;
           
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            divider = greatCD(a, b);
            Console.WriteLine(divider);
        }

        private static int greatCD(int a, int b)
        {
            int reminder;
            while (b!=0)
            {
                reminder = a % b;
                a = b;
                b = reminder;
            }
            return a;

        }
    }
}
