using System;
using System.Text;


namespace _16.DecimalToHex
{
        //    Problem 16. Decimal to Hexadecimal Number

        //Using loops write a program that converts an integer number to its hexadecimal representation.
        //The input is entered as long. The output should be a variable of type string.
        //Do not use the built-in .NET functionality.
    class DecimalToHex
    {
        static string DecimalTohexadecimal(long decim)
        {
            var sbulder = new StringBuilder();
            while (decim >0)
            {
                var rm = decim % 16;
                decim /= 16;
                sbulder.Insert(0,((int)rm).ToString("X"));
            }
            return sbulder.ToString();
           
        }
        static void Main()
        {
            Console.WriteLine("Decimal to Hex decimal Number");
            Console.WriteLine("------------------------------");
            Console.Write("Enter a number in Decimal Format num = ");
            long input = long.Parse( Console.ReadLine());
            string num;
            num = DecimalTohexadecimal(input);
            Console.WriteLine(num);

        }
    }
}
