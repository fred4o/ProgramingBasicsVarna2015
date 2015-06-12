using System;

namespace _12.NullValueArithmetic
{
    class NullValue
    {
       
            //Problem 12. Null Values Arithmetic

        //Create a program that assigns null values to an integer and to a double variable.
        //Try to print these variables at the console.
        //Try to add some number or the null literal to these variables and print the result.
        static void Main()
        {
            int? firstVar = null;
            double? secondVar = null;

            Console.WriteLine("{0}\n{1}", firstVar, secondVar);

            firstVar = 5865;
            secondVar = -54.265;
            Console.WriteLine("{0}\n{1}", firstVar, secondVar);
        }
        
    }
}
