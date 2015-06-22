using System;


namespace _15.HexToDecimalNumber
{
    class HexToDecimal
    {
        //Problem 15. Hexadecimal to Decimal Number

        //Using loops write a program that converts a hexadecimal integer number to its decimal form.
        //The input is entered as string. The output should be a variable of type long.
        //Do not use the built-in .NET functionality.
        static long hexadecimalToDecimal(string hex)
        {
            hex = hex.ToLower();
            long decim = 0;
           
            for (int i = hex.Length - 1, power = 0; i >= 0; i--, power++)
            {
                char c = hex[i];
                if (c >= 'a' && c <= 'z')
                {
                    int temp = 0;
                    switch (c)
                    {
                        case 'a': temp = 10; break;
                        case 'b': temp = 11; break;
                        case 'c': temp = 12; break;
                        case 'd': temp = 13; break;
                        case 'e': temp = 14; break;
                        case 'f': temp = 15; break;
                    }
                    decim += temp * (long)Math.Pow(16, power);
                }
                else
                {
                    decim += Convert.ToInt32(c.ToString()) * (long)Math.Pow(16, power);
                }
            }
            return decim;
        }
        static void Main()
        {
            Console.WriteLine("Hexadecimal to Decimal Number");
            Console.WriteLine("------------------------------");
            Console.Write("Enter a number in Hexadecimal Format num = ");
            string input = Console.ReadLine();
            long num = 0;
            num = hexadecimalToDecimal(input);
            Console.WriteLine(num);

        }
    }
}
