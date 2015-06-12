using System;


namespace _04.NumberComparer
{
    class NumberComparer
    {
        //Problem 4.	Number Comparer
        //Write a program that gets two numbers from the console and prints the greater of them. 
        //Try to implement this without if statements.

        static void Main()
        {
            Console.WriteLine("Number Comparer.");
            Console.WriteLine("-----------------");

            Console.WriteLine("Enter 2 numbers for compare");
            Console.Write("First number = ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Second number = ");
            double secondNum = double.Parse(Console.ReadLine());

            double greater = Math.Max(firstNum, secondNum);
            Console.WriteLine("Greater number is: {0}", greater);
        }
    }
}
