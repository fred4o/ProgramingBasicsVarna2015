using System;


namespace _09.ExchangeVariableValues
{
    class ExchhangeValues
    {
        /*
        Problem 9.	Exchange Variable Values
        Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their
        values by using some programming logic. Print the variable values before and after the exchange.
        */

        static void Main()
        {
            int a, b;
           
            a = 5;
            b = 10;
            Console.WriteLine("a = {0}\nb = {1}",a,b);
            int holder = a;
            a = b;
            b = holder;
            Console.WriteLine("After Exchange \na = {0}\nb = {1}", a, b);

        }
    }
}
