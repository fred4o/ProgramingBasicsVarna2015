using System;


namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {

       /* Problem 2.	Float or Double?
        Which of the following values can be assigned to a variable of type float and which
        to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
        Write a program to assign the numbers in variables and print them to ensure no precision is lost.
       */

        static void Main()
        {
            double doubleNum;
            float floatNum;

            doubleNum = 34.567839023;
            floatNum = 12.345F;
            Console.WriteLine("{0} is double type,\n{1} is float type",doubleNum,floatNum);

            doubleNum = 8923.1234857;
            floatNum = 3456.091F;
            Console.WriteLine("{0} is double type,\n{1} is float type", doubleNum, floatNum);

        }
    }
}
