using System;


namespace _03.VariableInHex
{
    class VariableInHex
    {
       /* Problem 3.	Variable in Hexadecimal Format
        Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
        Use Windows Calculator to find its hexadecimal representation. 
        Print the variable and ensure that the result is “254”.*/

        static void Main()
        {
            int num = 0xFE;
            Console.WriteLine("integer representation of 0xFE is {0} ",num);
        }
    }
}
